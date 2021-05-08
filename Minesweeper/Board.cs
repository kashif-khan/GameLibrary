using System;
using System.Diagnostics;
using System.Text;

namespace Minesweeper
{

    [DebuggerDisplay("{DebugDisplay}")]
    public class Board
    {
        public const byte landMine = 9;

        private byte[,] board;

        public Board(int rows, int columns, ILandmineInstaller landmineInstaller, ILandminesCalculator landminesCalculator, ILandmineDetector landminesDetector)
        {
            board = new byte[rows, columns];
            landmineInstaller.InstallLandmine(board, landMine, landminesCalculator);
            landminesDetector.DetectLandmines(board, landMine, IsLandmine);
        }

        public static bool IsLandmine(byte[,] board, int row, int column)
        {
            if (board[row, column] == landMine)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return DebugDisplay;
        }

        private string DebugDisplay
        {
            get
            {
                var debuggerDisplay = new StringBuilder();

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        debuggerDisplay.Append($"{board[i, j]} ");
                    }
                    debuggerDisplay.AppendLine($"");
                }
                Debug.WriteLine(debuggerDisplay.ToString());
                return debuggerDisplay.ToString();
            }
        }
    }
}
