using System;

namespace Minesweeper
{
    public interface ILandmineDetector
    {
        void DetectLandmines(byte[,] board, byte landMine, Func<byte[,], int, int, bool> IsLandmine);
    }
}