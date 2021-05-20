using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Client.Runtime
{    
    public sealed class GridModel
    {

        
        public const int Size = 3;
        
        public CellModel[,] CellModelArray = new CellModel[Size, Size];

        //Constructor creates cellmodels for array
        public GridModel()
        {
            for(int i = 0; i<Size; i++)
            {
                for(int j = 0; j<Size; j++)
                {
                    CellModelArray[i,j] = new CellModel(default);
                    
                }
            }
        }
        
    }

}
