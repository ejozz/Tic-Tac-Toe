using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.SceneManagement;

namespace TicTacToe.Client.Runtime
{
    public sealed class GameBehaviorTree : MonoBehaviour
    {
        [SerializeField] private CellClickHandler[] m_handlers = default;
        [SerializeField] private CellPresenter[] m_presenters = default;
        [SerializeField] private Effect[] m_animators = default;
        [SerializeField] private Effect[] m_winAnimators = default;
        [SerializeField] private GameObject m_restartButton = default;
        [SerializeField] private Effect m_restartEffect = default;

        private readonly Dictionary<Vector2Int, CellPresenter> m_grid = new Dictionary<Vector2Int, CellPresenter>();
        private readonly Dictionary<Vector2Int, SideAppearEffect> m_animatorGrid = new Dictionary<Vector2Int, SideAppearEffect>();
        private readonly Dictionary<Vector2Int, WinEffect> m_winAnimatorGrid = new Dictionary<Vector2Int, WinEffect>();
        private int m_moveCount = 0; 
        private WinHandler m_winHandler = new WinHandler();
        private GridModel m_gridModel = new GridModel();
        private Vector2Int[] m_winningPositions = new Vector2Int[GridModel.Size];
        private Side m_winningSide = default;
        private RestartClickHandler m_restartHandler;

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
            m_restartHandler = m_restartButton.GetComponent<RestartClickHandler>();
            m_restartButton.gameObject.SetActive(false);
        }

        //Subscribing to events
        private void OnEnable()
        {
            foreach (CellClickHandler handler in m_handlers)
            {
                handler.OnClicked += OnPresenterClicked;
            }
            m_restartHandler.OnClicked += OnRestart;
        }
        //unsubbing
        private void OnDisable()
        {
            foreach (CellClickHandler handler in m_handlers)
            {
                handler.OnClicked -= OnPresenterClicked;
            }
            m_restartHandler.OnClicked -= OnRestart;
        }

        //On Presenter Clicked event
        private void OnPresenterClicked(Vector2Int p)
        {     
            //if Cell has not been clicked/side=none
	        if(m_gridModel.CellModelArray[p.x,p.y].PlayerSide == Side.None)
	        {
		        //sets side randomly
                m_grid[p].Show(m_gridModel.CellModelArray[p.x,p.y] = new CellModel(GetRandomSide()));
	            m_moveCount++;
	            m_animatorGrid[p].Play();
                m_winningPositions = m_winHandler.CheckWin(m_gridModel);
                if(m_winningPositions!=null)
                {
                    m_winningSide = m_gridModel.CellModelArray[p.x, p.y].PlayerSide;

                    foreach(Vector2Int position in m_winningPositions)
                    {
                        m_winAnimatorGrid[position].Play();
                    }
                m_restartButton.gameObject.SetActive(true);
                m_restartEffect.Play();
                Debug.Log(m_winningSide + " wins.");
                Debug.Log("Winning positions at: " + m_winningPositions[0] + " , " + m_winningPositions[1] + " , " + m_winningPositions[2]);
                }
                if(m_moveCount == 9)
                {
                    Debug.Log("Board full.");
                    m_restartButton.gameObject.SetActive(true);
                    m_restartEffect.Play();
                }

            }
        }

        //On Restart event
        private void OnRestart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        //Test Function, Generates random side
        private Side GetRandomSide()
        {
            int m_randomNumber = Random.Range(0, 2);

            if (m_randomNumber == 1)
            {
                return Side.X;
            }

            else
            {
                return Side.O;
            }
            
        }
    }
}
