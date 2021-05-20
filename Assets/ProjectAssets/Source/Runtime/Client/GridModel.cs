using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Client.Runtime
{    
    public sealed class GridModel
    {
        
        public CellModel[,] CellModelArray = new CellModel[3, 3];

        //Constructor creates cellmodels for array
        public GridModel()
        {
            for(int i = 0; i<=2; i++)
            {
                for(int j = 0; j<=2; j++)
                {
                    CellModelArray[i,j] = new CellModel(default);
                    
                }
            }
        }
        
    }

}
