using UnityEngine;

namespace TicTacToe.Client.Runtime
{
    public sealed class GameBehaviorTree : MonoBehaviour
    {
        public GridModel gridModel = new GridModel();

        void OnEnable()
        {
            CellPresenter.OnClick += OnClickHandler;
        }

        void OnDisable()
        {
            CellPresenter.OnClick -= OnClickHandler;
        }

        //OnClick event
        public void OnClickHandler(CellPresenter presenter)
        {
            presenter.SetCell(ref gridModel);
            presenter.Show(gridModel);
        }
    }
}