namespace TicTacToe.Client.Runtime
{
    public sealed class PlayerModel
    {
        public Side Side { get; } = default;
        public int Score { get; private set;}

        public PlayerModel(Side side, int score)
        {
            Side = side;
            Score = score;
        }

        public int Win()
        {
            Score++;
            return Score;
        }
    }
}
