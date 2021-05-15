using System;

namespace Minesweeper
{
    public interface ILandmineDetector
    {
        void DetectLandmines(byte[,] board, byte landMine, Func<int, int, bool> IsLandmine);
    }
}