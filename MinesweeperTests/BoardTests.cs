using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper.Tests
{
    [TestClass()]
    public class BoardTests
    {
        [TestMethod()]
        public void IsLandmine0x0Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var clearGroundFinder = new DefaultClearGroundFinder();
            var board = new Board(0, 0, landminesInstaller, landminesCalculator, landminesDetector, clearGroundFinder);
        }

        [TestMethod()]
        public void IsLandmine0x1Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var clearGroundFinder = new DefaultClearGroundFinder();
            var board = new Board(0, 1, landminesInstaller, landminesCalculator, landminesDetector, clearGroundFinder);
        }

        [TestMethod()]
        public void IsLandmine1x0Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var clearGroundFinder = new DefaultClearGroundFinder();
            var board = new Board(1, 0, landminesInstaller, landminesCalculator, landminesDetector, clearGroundFinder);
        }

        [TestMethod()]
        public void IsLandmine1x1Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var clearGroundFinder = new DefaultClearGroundFinder();
            var board = new Board(1, 1, landminesInstaller, landminesCalculator, landminesDetector, clearGroundFinder);
        }

        [TestMethod()]
        public void IsLandmine1x2Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var clearGroundFinder = new DefaultClearGroundFinder();
            var board = new Board(1, 2, landminesInstaller, landminesCalculator, landminesDetector, clearGroundFinder);
        }

        [TestMethod()]
        public void IsLandmine2x1Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var clearGroundFinder = new DefaultClearGroundFinder();
            var board = new Board(2, 1, landminesInstaller, landminesCalculator, landminesDetector, clearGroundFinder);
        }

        [TestMethod()]
        public void IsLandmine2x2Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var clearGroundFinder = new DefaultClearGroundFinder();
            var board = new Board(2, 2, landminesInstaller, landminesCalculator, landminesDetector, clearGroundFinder);
        }


        [TestMethod()]
        public void IsLandmineTest()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var clearGroundFinder = new DefaultClearGroundFinder();
            var board = new Board(4, 4, landminesInstaller, landminesCalculator, landminesDetector, clearGroundFinder);
            //board.IsLandmine(2, 2);
        }

        [TestMethod()]
        public void IsFreeSpaceTest()
        {
            var landminesInstaller = new NorthWestCornerLandmineInstaller4x4();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var clearGroundFinder = new DefaultClearGroundFinder();
            var board = new Board(4, 4, landminesInstaller, landminesCalculator, landminesDetector, clearGroundFinder);
            var freeSpaces = board.GetFreeSpaces(0, 3);
            var output = new byte[4, 4];
            foreach (var eachFreeSpace in freeSpaces)
            {
                output[eachFreeSpace.DimesionX, eachFreeSpace.DimensionY] = 9;
            }
            var outputString = board.DisplayBoard(output);
        }
    }
    public class NorthWestCornerLandmineInstaller4x4 : ILandmineInstaller
    {
        // 9 1 0 0 
        // 1 1 0 0 
        // 0 0 0 0 
        // 0 0 0 0 
        public void InstallLandmine(byte[,] board, byte landmine, ILandminesCalculator landmineCalculator)
        {
            board[0, 0] = landmine;
        }
    }

}