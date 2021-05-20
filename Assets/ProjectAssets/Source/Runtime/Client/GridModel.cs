using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Client.Runtime
{    
    public sealed class GridModel
    {
        
        public CellModel[,] CellModelArray = new CellModel[3, 3];
        public CellPresenter[,] CellPresenterArray = new CellPresenter[3, 3];
        
    }

}
