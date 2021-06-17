namespace TicTacToe.Client.Runtime
{
    public class AlternateSides
    {
        private int m_count = 0;

        public Side GetSide()
        {
            Side side = default;

            if((m_count % 2) == 0)
            {
                side = Side.X;
            }
            else
            {
                side = Side.O;
            }
            m_count++;
            return side;
        }
    }
}