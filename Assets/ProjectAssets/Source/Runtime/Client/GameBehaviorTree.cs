using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TicTacToe.Client.Runtime
{    
    public sealed class GameBehaviorTree : MonoBehaviour
    {
        void Start()
        {
           
            GridModel Grid = new GridModel();

            for(int i = 0; i<=2; i++)
            {
                for(int j = 0; j<=2; j++)
                {
                    Grid.CellModelArray[i,j] = new CellModel(default);
                    Grid.CellPresenterArray[i,j] = new CellPresenter();

                    Grid.CellPresenterArray[i,j].Show(Grid.CellModelArray[i,j]);
                }
            }
        
        }
        
    }

}
