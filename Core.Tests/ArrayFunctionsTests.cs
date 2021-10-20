using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests
{
    public class ArrayFunctionsTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(new int[] { 3, 6, 1, 7, 2 }, 0, 4, 1)]
        [TestCase(new int[] { 0, 1, 2 }, 0, 2, 0)]
        [TestCase(new int[] { 23, 5, 3, 5, -7 }, 0, 4, -7)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 2, 5, 2)]
        [TestCase(new int[] { 3, 1, 2, 5, -10, 2 }, 0, 2, 1)]
        public void FindMinValueTest(int[] array, int startIndex, int endIndex, int expected)
        {
            //arrange

            //act
            int actual = ArrayFunctions.FindMinValue(array, startIndex, endIndex);

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3 }, 0, 3)]
        [TestCase(new int[] { 1, 2, 3 }, -1, 2)]
        public void FindMinValueTestNegative(int[] array, int startIndex, int endIndex)
        {
            //arrange

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => ArrayFunctions.FindMinValue(array, startIndex, endIndex));

        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void FindMinValue2DimensionalTest(int index2DimensionalArray)
        {
            //arrange
            int[,] array = TestData.GetArrayForFindMinValue2DimensionalTest(index2DimensionalArray);
            int expected = TestData.GetExpectedForFindMinValue2DimensionalTest(index2DimensionalArray);

            //act
            int actual = ArrayFunctions.FindMinValue(array);

            //assert

            Assert.AreEqual(expected, actual);

        }



        [TestCase(new int[] { 3, 6, 1, 7, 2 }, 0, 4, 7)]
        [TestCase(new int[] { 0, 1, 2 }, 0, 2, 2)]
        [TestCase(new int[] { 23, 5, 3, 5, -7 }, 0, 4, 23)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 2, 5, 5)]
        [TestCase(new int[] { 3, 1, 2, 5, -10, 2 }, 0, 2, 3)]
        public void FindMaxValueTest(int[] array, int startIndex, int endIndex, int expected)
        {
            //arrange

            //act
            int actual = ArrayFunctions.FindMaxValue(array, startIndex, endIndex);

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3 }, 0, 3)]
        [TestCase(new int[] { 1, 2, 3 }, -1, 2)]
        public void FindMaxValueTestNegative(int[] array, int startIndex, int endIndex)
        {
            //arrange

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => ArrayFunctions.FindMaxValue(array, startIndex, endIndex));

        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void FindMaxValue2DimensionalTest(int index2DimensionalArray)
        {
            //arrange
            int[,] array = TestData.GetArrayForFindMaxValue2DimensionalTest(index2DimensionalArray);
            int expected = TestData.GetExpectedForFindMaxValue2DimensionalTest(index2DimensionalArray);

            //act
            int actual = ArrayFunctions.FindMaxValue(array);

            //assert

            Assert.AreEqual(expected, actual);

        }


        [TestCase(new int[] { 3, 6, 1, 7, 2 }, 0, 4, 2)]
        [TestCase(new int[] { 0, 1, 2 }, 0, 2, 0)]
        [TestCase(new int[] { 23, 5, 3, 5, -7 }, 0, 4, 4)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 2, 5, 2)]
        [TestCase(new int[] { 3, 1, 2, 5, -10, 2 }, 0, 2, 1)]
        public void FindIndexOfMinValueTest(int[] array, int startIndex, int endIndex, int expected)
        {
            //arrange

            //act
            int actual = ArrayFunctions.FindIndexOfMinValue(array, startIndex, endIndex);

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3 }, 0, 3)]
        [TestCase(new int[] { 1, 2, 3 }, -1, 2)]
        public void FindIndexOfMinValueTestNegative(int[] array, int startIndex, int endIndex)
        {
            //arrange

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => ArrayFunctions.FindIndexOfMinValue(array, startIndex, endIndex));

        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void FindIndexOfMinValue2DimensionalTest(int index2DimensionalArray)
        {
            //arrange
            int[,] array = TestData.GetArrayForFindIndexOfMinValue2DimensionalTest(index2DimensionalArray);
            (int expected, int expected2) = TestData.GetExpectedForFindIndexOfMinValue2DimensionalTest(index2DimensionalArray);

            //act
            (int actual, int actual2) = ArrayFunctions.FindIndexOfMinValue(array);

            //assert

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);

        }


        [TestCase(new int[] { 3, 6, 1, 7, 2 }, 0, 4, 3)]
        [TestCase(new int[] { 0, 1, 2 }, 0, 2, 2)]
        [TestCase(new int[] { 23, 5, 3, 5, -7 }, 0, 4, 0)]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, 2, 5, 5)]
        [TestCase(new int[] { 3, 1, 2, 5, -10, 2 }, 0, 2, 0)]
        public void FindIndexOfMaxValueTest(int[] array, int startIndex, int endIndex, int expected)
        {
            //arrange

            //act
            int actual = ArrayFunctions.FindIndexOfMaxValue(array, startIndex, endIndex);

            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3 }, 0, 3)]
        [TestCase(new int[] { 1, 2, 3 }, -1, 2)]
        public void FindIndexOfMaxValueTestNegative(int[] array, int startIndex, int endIndex)
        {
            //arrange

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => ArrayFunctions.FindIndexOfMaxValue(array, startIndex, endIndex));

        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void FindIndexOfMaxValue2DimensionalTest(int index2DimensionalArray)
        {
            //arrange
            int[,] array = TestData.GetArrayForFindIndexOfMaxValue2DimensionalTest(index2DimensionalArray);
            (int expected, int expected2) = TestData.GetExpectedForFindIndexOfMaxValue2DimensionalTest(index2DimensionalArray);

            //act
            (int actual, int actual2) = ArrayFunctions.FindIndexOfMaxValue(array);

            //assert

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected2, actual2);

        }


        [TestCase(new int[] { 3, 1, 2, 5, -10, 2 }, 8)]
        [TestCase(new int[] { 5 }, 0)]
        [TestCase(new int[] { -1, -5, -6, -2, -4 }, -7)]
        [TestCase(new int[] { 0, -2, 0, 3, 5, 4, 10, 12 }, 17)]
        public void SumOfElementsWithOddIndexesTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = ArrayFunctions.SumOfElementsWithOddIndexes(array);

            //assert

            Assert.AreEqual(expected, actual);

        }


        [TestCase(new int[] { 0, 1, 2, 3 }, new int[] { 3, 2, 1, 0 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1, 0 })]
        [TestCase(new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void GetNewReversedArrayTest(int[] array, int[] expected)
        {
            //arrange

            //act
            int[] actual = ArrayFunctions.GetNewReversedArray(array);

            //assert

            Assert.AreEqual(expected, actual);

        }


        [TestCase(new int[] { 0, 1, 2, 3 }, new int[] { 3, 2, 1, 0 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1, 0 })]
        [TestCase(new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        public void ReverseArrayTest(int[] array, int[] expected)
        {
            //arrange

            //act
            ArrayFunctions.ReverseArray(array);

            //assert

            Assert.AreEqual(expected, array);

        }


        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6 }, 3)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 3, 5, 7, 9, 11 }, 6)]
        [TestCase(new int[] { 1, 3, 5, 7, 9, -11 }, 6)]
        public void GetCountOfOddElementsTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = ArrayFunctions.GetCountOfOddElements(array);

            //assert

            Assert.AreEqual(expected, actual);

        }


        [TestCase(new int[] { 0, 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 0, 1, 2 })]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, new int[] { 3, 4, 2, 0, 1 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        public void ReplaceLeftAndRightPartTest(int[] array, int[] expected)
        {
            //arrange

            //act
            ArrayFunctions.ReplaceLeftAndRightPart(array);

            //assert

            Assert.AreEqual(expected, array);

        }


        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { 5, 4, 7, 10, -1 }, new int[] { -1, 4, 5, 7, 10 })]
        [TestCase(new int[] { -1, 10, -1, 2, 7 }, new int[] { -1, -1, 2, 7, 10 })]
        [TestCase(new int[] { -1, 10, -1, 10, -1 }, new int[] { -1, -1, -1, 10, 10 })]
        public void SortArrayAscTest(int[] array, int[] expected)
        {
            //arrange

            //act
            ArrayFunctions.SortArrayAsc(array);

            //assert

            Assert.AreEqual(expected, array);

        }

        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { 5, 4, 7, 10, -1 }, new int[] { 10, 7, 5, 4, -1 })]
        [TestCase(new int[] { -1, 10, -1, 2, 7 }, new int[] { 10, 7, 2, -1, -1 })]
        [TestCase(new int[] { -1, 10, -1, 10, -1 }, new int[] { 10, 10, -1, -1, -1 })]
        public void SortArrayDescTest(int[] array, int[] expected)
        {
            //arrange

            //act
            ArrayFunctions.SortArrayDesc(array);

            //assert

            Assert.AreEqual(expected, array);

        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void GetCountOfElementsGreaterThanNeighboursTest(int index2DimensionalArray)
        {
            //arrange
            int[,] array = TestData.GetArrayForGetCountOfElementsGreaterThanNeighboursTest(index2DimensionalArray);
            int expected = TestData.GetExpectedForGetCountOfElementsGreaterThanNeighboursTest(index2DimensionalArray);

            //act
            int actual = ArrayFunctions.GetCountOfElementsGreaterThanNeighbours(array);

            //assert

            Assert.AreEqual(expected, actual);

        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void MirrorArrayAboutMainDiagonalTest(int index2DimensionalArray)
        {
            //arrange
            int[,] array = TestData.GetArrayForMirrorArrayAboutMainDiagonalTest(index2DimensionalArray);
            int[,] expected = TestData.GetExpectedForMirrorArrayAboutMainDiagonalTest(index2DimensionalArray);

            //act
            ArrayFunctions.MirrorArrayAboutMainDiagonal(array);

            //assert

            Assert.AreEqual(expected, array);

        }
    }
}
