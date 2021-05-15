using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minesweeper.Tests
{
    [TestClass()]
    public class DefaultLandmineDetectorTests
    {
        private readonly byte landMine = 9;
        byte[,] board;

        /// <summary>
        /// Actual Input
        /// |0|0|0|9|
        /// |0|0|0|0|
        /// |0|0|0|0|
        /// |0|0|0|0|
        /// Expected Output
        /// |0|0|1|9|
        /// |0|0|1|1|
        /// |0|0|0|0|
        /// |0|0|0|0|
        /// </summary>
        [TestMethod()]
        public void DetectLandminesTest()
        {
            var defaultLandmineDetector = new DefaultLandmineDetector();
            board = new byte[4, 4] { { 0, 0, 0, landMine }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
            var expectedOutput = "0019001100000000";
            defaultLandmineDetector.DetectLandmines(board, landMine, IsLandmine);
            var outputAccumulator = new StringBuilder();
            for (int rowindex = 0; rowindex < board.GetLength(0); rowindex++)
            {
                for (int columnIndex = 0; columnIndex < board.GetLength(1); columnIndex++)
                {
                    outputAccumulator.Append(board[rowindex, columnIndex]);
                }
            }
            Assert.AreEqual(expectedOutput, outputAccumulator.ToString());
        }

        private bool IsLandmine(int arg2, int arg3)
        {
            if (board[arg2, arg3] == landMine)
            {
                return true;
            }
            return false;
        }
    }
}