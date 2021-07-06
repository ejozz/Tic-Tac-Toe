namespace TicTacToe.Client.Runtime
{
    public sealed class WinPopupModel
    {
        public readonly string m_winMessage;

        public WinPopupModel(Side side)
        {
            if(side == Side.X)
            {
                m_winMessage = "X wins!";
            }
            else if(side == Side.O)
            {
                m_winMessage = "O wins!";
            }
            else
            {
                m_winMessage = "Tie!";
            }
        }
    }
}

