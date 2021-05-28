using UnityEngine;
using System.Collections.Generic;

namespace TicTacToe.Client.Runtime
{
    public sealed class GameBehaviorTree : MonoBehaviour
    {
        [SerializeField] private CellClickHandler[] m_handlers = default;
        [SerializeField] private CellPresenter[] m_presenters = default;
        [SerializeField] private SideAppearEffect[] m_animators = default;
        private readonly Dictionary<Vector2Int, CellPresenter> m_grid = new Dictionary<Vector2Int, CellPresenter>();
        private readonly Dictionary<Vector2Int, SideAppearEffect> m_animatorGrid = new Dictionary<Vector2Int, SideAppearEffect>();
        private WinHandler m_winHandler = new WinHandler();
        private GridModel m_gridModel = new GridModel();
        private Vector2Int[] m_winningPositions = new Vector2Int[GridModel.Size];
        private Side m_winningSide = default;

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

        }

        //Subscribing to event
        private void OnEnable()
        {
            foreach (CellClickHandler handler in m_handlers)
            {
                handler.OnClicked += OnPresenterClicked;
            }
        }
        //unsubbing
        private void OnDisable()
        {
            foreach (CellClickHandler handler in m_handlers)
            {
                handler.OnClicked -= OnPresenterClicked;
            }
        }

        //On Presenter Clicked event
        private void OnPresenterClicked(Vector2Int p)
        {
            m_grid[p].Show(m_gridModel.CellModelArray[p.x,p.y] = new CellModel(GetRandomSide()));
            m_animatorGrid[p].Play();
            m_winningPositions = m_winHandler.CheckWin(m_gridModel);
            if(m_winningPositions!=null)
            {
                m_winningSide = m_gridModel.CellModelArray[p.x, p.y].PlayerSide;
                Debug.Log(m_winningSide + " wins.");
                Debug.Log("Winning positions at: " + m_winningPositions[0] + " , " + m_winningPositions[1] + " , " + m_winningPositions[2]);
            }
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