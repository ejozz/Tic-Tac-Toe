using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

namespace TicTacToe.Client.Runtime
{    
    public sealed class GameBehaviorTree : MonoBehaviour
    {
        
        public GridModel gridModel = new GridModel();
        

        void OnEnable()
        {
            CellPresenter.OnClick += delegate(CellPresenter presenter)
            {
                presenter.SetCell(ref gridModel);
                presenter.Show(gridModel);
            };
        }

        
        
    }

}
