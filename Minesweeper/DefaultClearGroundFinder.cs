using System;
using System.Collections.Generic;

namespace Minesweeper
{
    public class DefaultClearGroundFinder : IClearGroundFinder<int, int>
    {
        HashSet<(int, int)> visitedCells = new HashSet<(int, int)>();

        public void FindConnectedClearGround(byte[,] board, (int DimesionX, int DimensionY) givenInput, IList<(int DimesionX, int DimensionY)> listOfConnectedFreeSpaces)
        {
            for (int rowIndex = -1; rowIndex <= 1; rowIndex++)
            {
                for (int columnIndex = -1; columnIndex <= 1; columnIndex++)
                {
                    var calculatedRowIndex = givenInput.DimesionX + rowIndex;
                    var calculatedColumnIndex = givenInput.DimensionY + columnIndex;
                    if (calculatedRowIndex >= 0 && calculatedRowIndex < board.GetLength(0) && calculatedColumnIndex >= 0 && calculatedColumnIndex < board.GetLength(1))
                    {
                        if (board[calculatedRowIndex, calculatedColumnIndex] == 0 && !visitedCells.Contains((calculatedRowIndex, calculatedColumnIndex)))
                        {
                            visitedCells.Add((calculatedRowIndex, calculatedColumnIndex));
                            FindConnectedClearGround(board, (calculatedRowIndex, calculatedColumnIndex), listOfConnectedFreeSpaces);
                            listOfConnectedFreeSpaces.Add((calculatedRowIndex, calculatedColumnIndex));
                        }
                    }
                }
            }
        }
    }
}
