using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace TicTacToe.Client.Runtime
{
    public sealed class GameBehaviorTree : MonoBehaviour
    {
        [SerializeField] private CellClickHandler[] m_handlers = default;
        [SerializeField] private CellPresenter[] m_presenters = default;
        [SerializeField] private Effect[] m_animators = default;
        [SerializeField] private Effect[] m_winAnimators = default;
        [SerializeField] private Effect m_restartEffect = default;
        [SerializeField] private RestartPresenter m_restartPresenter = default;
        [SerializeField] private ScorePresenter m_xScorePresenter = default;
        [SerializeField] private ScorePresenter m_oScorePresenter = default;

        private readonly Dictionary<Vector2Int, CellPresenter> m_grid = new Dictionary<Vector2Int, CellPresenter>();
        private readonly Dictionary<Vector2Int, SideAppearEffect> m_animatorGrid = new Dictionary<Vector2Int, SideAppearEffect>();
        private readonly Dictionary<Vector2Int, WinEffect> m_winAnimatorGrid = new Dictionary<Vector2Int, WinEffect>();
        private WinHandler m_winHandler = new WinHandler();
        private GridModel m_gridModel = new GridModel();
        private Vector2Int[] m_winningPositions = new Vector2Int[GridModel.Size];
        private Side m_winningSide = default;
        private RestartModel m_restartModel = new RestartModel();
        private PlayerModel m_xPlayer = PlayerModel.GetXPlayer;
        private PlayerModel m_oPlayer = PlayerModel.GetOPlayer;
        private PlayerModel m_activePlayer;

        private void Awake()
        {
            foreach (CellPresenter presenter in m_presenters)
            {
                GridPosition p = presenter.GetComponent<GridPosition>();
                m_grid.Add(p.Value, presenter);
            }

            foreach (SideAppearEffect animator in m_animators)
            {
                GridPosition p = animator.GetComponent<GridPosition>();
                m_animatorGrid.Add(p.Value, animator);
            }
            foreach (WinEffect winAnimator in m_winAnimators)
            {
                GridPosition p = winAnimator.GetComponent<GridPosition>();
                m_winAnimatorGrid.Add(p.Value, winAnimator);
            }
            m_restartPresenter.Hide();
            m_xScorePresenter.Show(m_xPlayer.m_score);
            m_oScorePresenter.Show(m_oPlayer.m_score);
            m_activePlayer = m_xPlayer;
            
        }

        //Subscribing to events
        private void OnEnable()
        {
            foreach (CellClickHandler handler in m_handlers)
            {
                handler.OnClicked += OnPresenterClicked;
            }
            m_restartPresenter.OnClicked += OnRestart;
        }

        //unsubbing
        private void OnDisable()
        {
            foreach (CellClickHandler handler in m_handlers)
            {
                handler.OnClicked -= OnPresenterClicked;
            }
            m_restartPresenter.OnClicked -= OnRestart;
        }

        //On Presenter Clicked event
        private void OnPresenterClicked(Vector2Int p)
        {     
            //if Cell has not been clicked/side=none
	        if(m_gridModel.CellModelArray[p.x,p.y].PlayerSide == Side.None)
	        {
		        //sets side randomly
                m_grid[p].Show(m_gridModel.CellModelArray[p.x,p.y] = new CellModel(m_activePlayer.m_side));
	            m_animatorGrid[p].Play();
                m_winningPositions = m_winHandler.CheckWin(m_gridModel);

                //if there is a winner
                if(m_winningPositions!=null)
                {
                    m_winningSide = m_gridModel.CellModelArray[p.x, p.y].PlayerSide;

                    foreach(Vector2Int position in m_winningPositions)
                    {
                        m_winAnimatorGrid[position].Play();
                    }
                    m_restartPresenter.Show();
                    m_restartEffect.Play();

                    if(m_winningSide == Side.X)
                    {
                        m_xScorePresenter.Show(m_xPlayer.Win());
                    }
                    else
                    {
                        m_oScorePresenter.Show(m_oPlayer.Win());
                    }

                    Debug.Log(m_winningSide + " wins.");
                    Debug.Log("Winning positions at: " + m_winningPositions[0] + " , " + m_winningPositions[1] + " , " + m_winningPositions[2]);
                }

                //elif board is full
                else if(m_gridModel.IsFull() == true)
                {
                    Debug.Log("Board full.");
                    m_restartPresenter.Show();
                    m_restartEffect.Play();
                }

                //switch active player
                if(m_activePlayer == m_xPlayer)
                {
                    m_activePlayer = m_oPlayer;
                }
                else
                {
                    m_activePlayer = m_xPlayer;
                }
            }
        }

        //On Restart event
        private void OnRestart()
        {
            m_restartModel.Restart();
        }
    }
}
