using System;

namespace Minesweeper
{
    public class DefaultLandmineInstaller : ILandmineInstaller
    {
        public void InstallLandmine(byte[,] board, byte landmine, ILandminesCalculator landmineCalculator)
        {
            var boardRowMax = board.GetLength(0);
            var boardColumnMax = board.GetLength(1);
            var boardRowIndex = boardRowMax - 1;
            var boardColumnIndex = boardColumnMax - 1;
            var landminesToInstall = landmineCalculator.LandminesToInstall(boardRowMax, boardColumnMax);
            var random = new Random();

            for (int i = 0; i < landminesToInstall; i++)
            {
                var randomRowIndex = random.Next(0, boardRowIndex);
                var randomColumnIndex = random.Next(0, boardColumnIndex);

                board[randomRowIndex, randomColumnIndex] = landmine;
            }
        }
    }
}