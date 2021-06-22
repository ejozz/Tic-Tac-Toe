namespace TicTacToe.Client.Runtime
{
    public sealed class PlayerModel
    {
        private static PlayerModel m_xPlayer;
        private static PlayerModel m_oPlayer;

        public Side m_side { get; } = default;
        public int m_score { get; private set;}

        public static PlayerModel GetXPlayer
        {
            get
            {
                if(m_xPlayer == null)
                {
                    m_xPlayer = new PlayerModel(Side.X, 0);
                }
                return m_xPlayer;
            }
        }

        public static PlayerModel GetOPlayer
        {
            get
            {
                if(m_oPlayer == null)
                {
                    m_oPlayer = new PlayerModel(Side.O, 0);
                }
                return m_oPlayer;
            }
        }

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
