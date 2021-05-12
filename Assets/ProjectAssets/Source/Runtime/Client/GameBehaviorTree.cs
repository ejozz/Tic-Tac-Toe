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

            CellPresenter CellPresenter = new CellPresenter();

            for(int i = 0; i<=2; i++)
            {
                for(int j = 0; j<=2; j++)
                {
                    Grid.CellArray[i,j] = new CellModel(default);
                }
            }
        
        }
        
    }

}
