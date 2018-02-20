using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HellsTriangle;

namespace HellsTriangleTests
{
    [TestClass]
    public class HellsTriangleProcessorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetMaxTotal_NullTriangle_ThrowsException()
        {
            // Arrange
            int[][] triangle = null;

            // Act
            long actualResult = new HellsTriangleProcessor().GetMaxTotal(triangle);
        }

        [TestMethod]
        public void GetMaxTotal_EmptyTriangle_Returns0()
        {
            // Arrange
            long expectedResult = 0;
            int[][] triangle = new int[0][];

            // Act
            long actualResult = new HellsTriangleProcessor().GetMaxTotal(triangle);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetMaxTotal_InvalidTriangle_ThrowsException()
        {
            // Arrange
            int[][] triangle = new int[2][];
            triangle[0] = new int[] { 4 };
            triangle[1] = new int[] { 4 };

            // Act
            long actualResult = new HellsTriangleProcessor().GetMaxTotal(triangle);
        }

        [TestMethod]
        public void GetMaxTotal_OneLevelTriangle_ReturnsElementValue()
        {
            // Arrange
            int level1 = 123456;
            long expectedResult = level1;

            int[][] triangle = new int[1][];
            triangle[0] = new int[] { level1 };

            // Act
            long actualResult = new HellsTriangleProcessor().GetMaxTotal(triangle);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetMaxTotal_MultipleLevelsTriangle_ReturnsMaxSumOfAdjacentValues()
        {
            // Arrange
            long expectedResult = 26;

            int[][] triangle = new int[4][];
            triangle[0] = new int[] { 6 };
            triangle[1] = new int[] { 3,5 };
            triangle[2] = new int[] { 9,7,1 };
            triangle[3] = new int[] { 4,6,8,4 };

            // Act
            long actualResult = new HellsTriangleProcessor().GetMaxTotal(triangle);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetMaxTotal_AllTriangleNodesWithMaxIntValue_ReturnsMaxSumAsLong()
        {
            // Arrange
            int length = 1000;
            long expectedResult = Math.BigMul(length, int.MaxValue);

            int[][] triangle = new int[length][];
            for(int i = 0; i < triangle.Length; i++)
            {
                triangle[i] = new int[i+1];
                for(int j = 0; j < i+1; j++)
                {
                    triangle[i][j] = int.MaxValue;
                }
            }

            // Act
            long actualResult = new HellsTriangleProcessor().GetMaxTotal(triangle);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
