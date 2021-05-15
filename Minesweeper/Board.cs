using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Minesweeper
{

    [DebuggerDisplay("{DebugDisplay}")]
    public class Board
    {
        public const byte landMine = 9;
        public const byte freeSpace = 0;
        private readonly IClearGroundFinder<int, int> _clearGroundFinder;
        private readonly byte[,] _board;

        public Board(int rows, int columns, ILandmineInstaller landmineInstaller, ILandminesCalculator landminesCalculator, ILandmineDetector landminesDetector, IClearGroundFinder<int, int> clearGroundFinder)
        {
            _board = new byte[rows, columns];
            landmineInstaller.InstallLandmine(_board, landMine, landminesCalculator);
            landminesDetector.DetectLandmines(_board, landMine, this.IsLandmine);
            _clearGroundFinder = clearGroundFinder;
        }

        public bool IsLandmine(int row, int column)
        {
            if (_board[row, column] == landMine)
            {
                return true;
            }
            return false;
        }

        public bool IsFreeSpace(int row, int column)
        {
            if (_board[row, column] == freeSpace)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<(int DimesionX, int DimensionY)> GetFreeSpaces(int row, int column)
        {
            var listOfSpaces = new List<(int DimensionX, int DimenesionY)>();
            _clearGroundFinder.FindConnectedClearGround(_board, (row, column), listOfSpaces);
            return listOfSpaces;
        }

        public override string ToString()
        {
            return DebugDisplay;
        }

        private string DebugDisplay
        {
            get
            {
                var debuggerDisplay = DisplayBoard(this._board);
                Debug.WriteLine(debuggerDisplay);
                return debuggerDisplay;
            }
        }

        public string DisplayBoard(byte[,] _board)
        {
            var debuggerDisplay = new StringBuilder();

            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    debuggerDisplay.Append($"{_board[i, j]} ");
                }
                debuggerDisplay.AppendLine($"");
            }
            return debuggerDisplay.ToString();
        }
    }
}
