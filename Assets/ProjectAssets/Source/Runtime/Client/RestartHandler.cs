using UnityEngine;
using UnityEngine.SceneManagement;

namespace TicTacToe.Client.Runtime
{
    public sealed class RestartHandler : MonoBehaviour
    {
        [SerializeField] private GameObject m_restartButton = default;

        public void EnableButton()
        {
            m_restartButton.gameObject.SetActive(true);
        }

        public void DisableButtton()
        {
            m_restartButton.gameObject.SetActive(false);
        }

        public void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        public bool CheckFull(GridModel grid)
        {
            for(int j = 0; j<GridModel.Size; j++)
            {
                for(int k = 0; k<GridModel.Size; k++)
                {
                    if(grid.CellModelArray[j,k].PlayerSide == Side.None)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}