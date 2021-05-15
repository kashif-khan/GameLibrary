using System.Collections.Generic;

namespace Minesweeper
{
    public interface IClearGroundFinder<TDimensionX, TDimensionY>
    {
        void FindConnectedClearGround(byte[,] board, (TDimensionX DimesionX, TDimensionY DimensionY) givenInput, IList<(TDimensionX DimesionX, TDimensionY DimensionY)> listOfConnectedFreeSpaces);
    }
}
