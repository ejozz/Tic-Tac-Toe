using UnityEngine;

namespace TicTacToe.Client.Runtime
{
    public sealed class ScoreModel
    {
        private static int m_xScore = 0;
        private static int m_oScore = 0;
        
        public int GetX()
        {
            return m_xScore;
        }

        public int GetO()
        {
            return m_oScore;
        }

        public int XWin()
        {
            m_xScore++;
            return m_xScore;
        }

        public int OWin()
        {
            m_oScore++;
            return m_oScore;
        }
    }
}