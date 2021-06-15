using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TicTacToe.Client.Runtime
{
    public class FullBoardHandler
    {
        private bool m_isFull;
        
        public bool CheckFull(GridModel grid)
        {
            m_isFull = true;
            for(int j = 0; j<GridModel.Size; j++)
            {
                for(int k = 0; k<GridModel.Size; k++)
                {
                    if(grid.CellModelArray[j,k].PlayerSide == Side.None)
                    {
                        m_isFull = false;
                    }
                }
            }
            return m_isFull;
        }
    }
}