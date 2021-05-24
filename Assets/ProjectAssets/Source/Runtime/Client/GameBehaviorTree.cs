using UnityEngine;
using System.Collections.Generic;

namespace TicTacToe.Client.Runtime
{
    public sealed class GameBehaviorTree : MonoBehaviour
    {
        [SerializeField] private CellClickHandler[] m_handlers = default;
        [SerializeField] private CellPresenter[] m_presenters = default;
        private readonly Dictionary<Vector2Int, CellPresenter> m_grid = new Dictionary<Vector2Int, CellPresenter>();
        private WinHandler m_winHandler = new WinHandler();
        private GridModel m_gridModel = new GridModel();

        private void Awake()
        {
            foreach (CellPresenter presenter in m_presenters)
            {
                GridPosition p = presenter.GetComponent<GridPosition>();
                m_grid.Add(p.Value, presenter);
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
            m_winHandler.CheckWin(m_gridModel);
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