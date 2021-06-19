using UnityEngine;

namespace TicTacToe.Client.Runtime
{
    public sealed class ScoreModel
    {
        private int m_xScore = 0;
        private int m_oScore = 0;
       
        private static ScoreModel m_instance;
        
        public static ScoreModel Instance
        {
            get
            {
                if(m_instance == null)
                {
                    m_instance = new ScoreModel();
                }
                return m_instance;
            }
        }

        public int GetX()
        {
            return m_xScore;
        }

        public int GetO()
        {
            return m_oScore;
        }

        public void SetX(int score)
        {
            m_xScore = score;
        }

        public void SetO(int score)
        {
            m_oScore = score;
        }
    }
}