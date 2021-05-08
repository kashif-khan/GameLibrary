using System;

namespace Minesweeper
{
    public class DefaultLandmineDetector : ILandmineDetector
    {

        /// <summary>
        /// |0,0|0,1|0,2|
        /// |1,0|1,1|1,2|
        /// |2,0|2,1|2,2|
        /// </summary>
        /// <param name="board"></param>
        /// <param name="landMine"></param>
        public void DetectLandmines(byte[,] board, byte landMine, Func<int, int, bool> IsLandmine)
        {
            var rowMax = board.GetLength(0);
            var columnMax = board.GetLength(1);
            for (int rowIndex = 0; rowIndex < rowMax; rowIndex++)
            {
                for (int ColumnIndex = 0; ColumnIndex < columnMax; ColumnIndex++)
                {
                    if (board[rowIndex, ColumnIndex] != landMine)
                    {
                        // [0,0]
                        if (IsMyNeighborLandmine(board, IsLandmine, rowIndex - 1, ColumnIndex - 1))
                        {
                            board[rowIndex, ColumnIndex]++;
                        };
                        // [0,1]
                        if (IsMyNeighborLandmine(board, IsLandmine, rowIndex - 1, ColumnIndex))
                        {
                            board[rowIndex, ColumnIndex]++;
                        }
                        // [0,2]
                        if (IsMyNeighborLandmine(board, IsLandmine, rowIndex - 1, ColumnIndex + 1))
                        {
                            board[rowIndex, ColumnIndex]++;
                        }
                        // [1,0]
                        if (IsMyNeighborLandmine(board, IsLandmine, rowIndex, ColumnIndex - 1))
                        {
                            board[rowIndex, ColumnIndex]++;
                        }
                        // [1,2]
                        if (IsMyNeighborLandmine(board, IsLandmine, rowIndex, ColumnIndex + 1))
                        {
                            board[rowIndex, ColumnIndex]++;
                        }
                        // [2,0]
                        if (IsMyNeighborLandmine(board, IsLandmine, rowIndex + 1, ColumnIndex - 1))
                        {
                            board[rowIndex, ColumnIndex]++;
                        }
                        // [2,1]
                        if (IsMyNeighborLandmine(board, IsLandmine, rowIndex + 1, ColumnIndex))
                        {
                            board[rowIndex, ColumnIndex]++;
                        }
                        // [2,1]
                        if (IsMyNeighborLandmine(board, IsLandmine, rowIndex + 1, ColumnIndex + 1))
                        {
                            board[rowIndex, ColumnIndex]++;
                        }
                    }
                }
            }
        }

        private static bool IsMyNeighborLandmine(byte[,] board, Func<int, int, bool> IsLandmine, int rowIndex, int ColumnIndex)
        {
            if (rowIndex > -1 && rowIndex < board.GetLength(0) && ColumnIndex > -1 && ColumnIndex < board.GetLength(1) && IsLandmine(rowIndex, ColumnIndex))
            {
                return true;
            }
            return false;
        }
    }
}