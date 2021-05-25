using UnityEngine;

namespace TicTacToe.Client.Runtime
{
    public sealed class WinHandler
    {
        private Side m_winningSide = Side.None;
        private Side m_currentSide = Side.None;
        private Vector2Int[] m_winningPositions = new Vector2Int[GridModel.Size];

        //check win, 8 win cases per side, 3 horizontal, 3 vertical, 2 diagonal
        public Vector2Int[] CheckWin(GridModel grid)
        {
            for(int i = 0; i<=1; i++)
            {
                if(i==1)
                {
                    m_currentSide = Side.O;
                }
                else
                {
                    m_currentSide = Side.X;
                }
            
                //Vertical cases
                //Vert 1
                if(grid.CellModelArray[0, 0].PlayerSide == m_currentSide && grid.CellModelArray[0, 1].PlayerSide == m_currentSide && grid.CellModelArray[0, 2].PlayerSide == m_currentSide)
                {
                    m_winningSide = m_currentSide;
                    m_winningPositions[0] = new Vector2Int(0, 0);
                    m_winningPositions[1] = new Vector2Int(0, 1);
                    m_winningPositions[2] = new Vector2Int(0, 2);

                }

                //Vert 2
                else if (grid.CellModelArray[1, 0].PlayerSide == m_currentSide && grid.CellModelArray[1, 1].PlayerSide == m_currentSide && grid.CellModelArray[1, 2].PlayerSide == m_currentSide)
                {
                    m_winningSide = m_currentSide;
                    m_winningPositions[0] = new Vector2Int(1, 0);
                    m_winningPositions[1] = new Vector2Int(1, 1);
                    m_winningPositions[2] = new Vector2Int(1, 2);

                }

                //Vert 3
                else if (grid.CellModelArray[2, 0].PlayerSide == m_currentSide && grid.CellModelArray[2, 1].PlayerSide == m_currentSide && grid.CellModelArray[2, 2].PlayerSide == m_currentSide)
                {
                    m_winningSide = m_currentSide;
                    m_winningPositions[0] = new Vector2Int(2, 0);
                    m_winningPositions[1] = new Vector2Int(2, 1);
                    m_winningPositions[2] = new Vector2Int(2, 2);

                }

                //Horizontal Cases
                //Hor 1
                else if (grid.CellModelArray[0, 0].PlayerSide == m_currentSide && grid.CellModelArray[1, 0].PlayerSide == m_currentSide && grid.CellModelArray[2, 0].PlayerSide == m_currentSide)
                {
                    m_winningSide = m_currentSide;
                    m_winningPositions[0] = new Vector2Int(0, 0);
                    m_winningPositions[1] = new Vector2Int(1, 0);
                    m_winningPositions[2] = new Vector2Int(2, 0);

                }

                //Hor 2
                else if (grid.CellModelArray[0, 1].PlayerSide == m_currentSide && grid.CellModelArray[1, 1].PlayerSide == m_currentSide && grid.CellModelArray[2, 1].PlayerSide == m_currentSide)
                {
                    m_winningSide = m_currentSide;
                    m_winningPositions[0] = new Vector2Int(0, 1);
                    m_winningPositions[1] = new Vector2Int(1, 1);
                    m_winningPositions[2] = new Vector2Int(2, 1);

                }

                //Hor 3
                else if (grid.CellModelArray[0, 2].PlayerSide == m_currentSide && grid.CellModelArray[1, 2].PlayerSide == m_currentSide && grid.CellModelArray[2, 2].PlayerSide == m_currentSide)
                {
                    m_winningSide = m_currentSide;
                    m_winningPositions[0] = new Vector2Int(0, 2);
                    m_winningPositions[1] = new Vector2Int(1, 2);
                    m_winningPositions[2] = new Vector2Int(2, 2);

                }

                //Diagonal Cases
                //Diag 1
                else if (grid.CellModelArray[0, 0].PlayerSide == m_currentSide && grid.CellModelArray[1, 1].PlayerSide == m_currentSide && grid.CellModelArray[2, 2].PlayerSide == m_currentSide)
                {
                    m_winningSide = m_currentSide;
                    m_winningPositions[0] = new Vector2Int(0, 0);
                    m_winningPositions[1] = new Vector2Int(1, 1);
                    m_winningPositions[2] = new Vector2Int(2, 2);

                }

                //Diag 2
                else if (grid.CellModelArray[2, 0].PlayerSide == m_currentSide && grid.CellModelArray[1, 1].PlayerSide == m_currentSide && grid.CellModelArray[0, 2].PlayerSide == m_currentSide)
                {
                    m_winningSide = m_currentSide;
                    m_winningPositions[0] = new Vector2Int(0, 0);
                    m_winningPositions[1] = new Vector2Int(1, 1);
                    m_winningPositions[2] = new Vector2Int(2, 2);

                }
            }

            //if win
            if(m_winningSide == Side.X || m_winningSide == Side.O)
            {
                return m_winningPositions;
            }

            return null;


        }
    }
}