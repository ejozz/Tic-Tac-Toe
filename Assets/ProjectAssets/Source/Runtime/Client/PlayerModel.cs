namespace TicTacToe.Client.Runtime
{
    public sealed class PlayerModel
    {
        public Side m_side { get; } = default;
        public int m_score { get; private set;}

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
    }
}
