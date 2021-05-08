namespace Minesweeper
{
    public interface ILandmineInstaller
    {
        void InstallLandmine(byte[,] board, byte landmine, ILandminesCalculator landmineCalculator);
    }
}