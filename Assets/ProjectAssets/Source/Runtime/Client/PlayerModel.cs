namespace TicTacToe.Client.Runtime
{
    public sealed class PlayerModel
    {
        private Side m_side = default;
        private int m_score = 0;

        public PlayerModel(Side side, int score)
        {
            m_side = side;
            m_score = score;
        }

        public int Win()
        {
            m_score++;
            return m_score;
        }

        public int GetScore()
        {
            return m_score;
        }

        public Side GetSide()
        {
            return m_side;
        }
    }
}
