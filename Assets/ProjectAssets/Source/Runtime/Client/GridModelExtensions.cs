namespace TicTacToe.Client.Runtime
{
    public static class GridModelExtensions
    {
        public static bool IsFull(this GridModel grid)
        {
            bool m_isFull = true;
            for(int j = 0; j<GridModel.Size; j++)
            {
                for(int k = 0; k<GridModel.Size; k++)
                {
                    if(grid.CellModelArray[j,k].PlayerSide == Side.None)
                    {
                        m_isFull = false;
                    }
                }
            }
            return m_isFull;
        }
    }
}