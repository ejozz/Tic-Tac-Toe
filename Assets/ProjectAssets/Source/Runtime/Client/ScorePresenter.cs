using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe.Client.Runtime
{
    public sealed class ScorePresenter : MonoBehaviour
    {
        [SerializeField] private Text m_scoreText = default;
        
        //function sets text object to update view
        public void Show(int score)
        {
            m_scoreText.text = score.ToString();
        }
    }
}

