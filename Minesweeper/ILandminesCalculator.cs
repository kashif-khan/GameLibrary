using System;

namespace Minesweeper
{
    public interface ILandminesCalculator
    {
        int LandminesToInstall(int x, int y);
    }

    public class DefaultLandminesCalculator : ILandminesCalculator
    {
        public int defaultPercentage = 10;
        public int LandminesToInstall(int x, int y)
        {
            var landmines = (int)Math.Round((x * y) * (defaultPercentage / 100f), 0);

            if (landmines == 0)
            {
                var random = new Random();
                return random.Next(0, 1);
            }

            return landmines;
        }
    }
}