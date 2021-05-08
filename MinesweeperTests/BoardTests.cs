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
            var board = new Board(0, 0, landminesInstaller, landminesCalculator, landminesDetector);
        }

        [TestMethod()]
        public void IsLandmine0x1Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var board = new Board(0, 1, landminesInstaller, landminesCalculator, landminesDetector);
        }

        [TestMethod()]
        public void IsLandmine1x0Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var board = new Board(1, 0, landminesInstaller, landminesCalculator, landminesDetector);
        }

        [TestMethod()]
        public void IsLandmine1x1Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var board = new Board(1, 1, landminesInstaller, landminesCalculator, landminesDetector);
        }

        [TestMethod()]
        public void IsLandmine1x2Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var board = new Board(1, 2, landminesInstaller, landminesCalculator, landminesDetector);
        }

        [TestMethod()]
        public void IsLandmine2x1Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var board = new Board(2, 1, landminesInstaller, landminesCalculator, landminesDetector);
        }

        [TestMethod()]
        public void IsLandmine2x2Test()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var board = new Board(2, 2, landminesInstaller, landminesCalculator, landminesDetector);
        }


        [TestMethod()]
        public void IsLandmineTest()
        {
            var landminesInstaller = new DefaultLandmineInstaller();
            var landminesCalculator = new DefaultLandminesCalculator();
            var landminesDetector = new DefaultLandmineDetector();
            var board = new Board(4, 4, landminesInstaller, landminesCalculator, landminesDetector);
            //board.IsLandmine(2, 2);
        }
    }
}