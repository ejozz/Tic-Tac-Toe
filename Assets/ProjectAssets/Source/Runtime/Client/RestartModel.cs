using UnityEngine;
using UnityEngine.SceneManagement;

namespace TicTacToe.Client.Runtime
{
    public sealed class RestartModel
    {   
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}