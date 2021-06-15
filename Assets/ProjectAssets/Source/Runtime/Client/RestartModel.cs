using UnityEngine;
using UnityEngine.SceneManagement;

namespace TicTacToe.Client.Runtime
{
    public sealed class RestartModel
    {   
        private bool m_isFull;
        
        public void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

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