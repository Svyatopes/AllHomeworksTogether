using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests
{
    public static class TestData
    {
        public static List<int> GetExpectedListForGetAllNumbersFrom1To1000DividedTest(int enteredNumber)
        {
            return enteredNumber switch
            {
                -100 => new List<int>() { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 },
                100 => new List<int>() { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 },
                200 => new List<int>() { 200, 400, 600, 800, 1000 },
                500 => new List<int>() { 500, 1000 },
                _ => throw new NotImplementedException()
            };
        }

        public static List<int> GetExpecForGetAllNumbersWhereSumEvenDigitsMoreThanOddDigitsTest(int enteredNumber)
        {
            return enteredNumber switch
            {
                10 => new List<int>() { 2, 4, 6, 8 },
                35 => new List<int>() { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34 },
                _ => throw new NotImplementedException()
            };
        }

        public static int[,] GetArrayForFindMinValue2DimensionalTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                1 => new int[,] { { 4, 5, 6 }, { 1, 2, 3 }, { 7, 8, 9 } },
                2 => new int[,] { { 4, 5, 6 }, { 7, 8, 9 }, { 3, 2, 1 } },
                3 => new int[,] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } },
                _ => throw new NotImplementedException()
            };
        }

        public static int GetExpectedForFindMinValue2DimensionalTest(int index)
        {
            return index switch
            {
                0 => 1,
                1 => 1,
                2 => 1,
                3 => 2,
                _ => throw new NotImplementedException()
            };
        }

        public static int[,] GetArrayForFindMaxValue2DimensionalTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                1 => new int[,] { { 4, 5, 6 }, { 7, 8, 9 }, { 1, 2, 3 } },
                2 => new int[,] { { 9, 8, 1 }, { 4, 5, 6 }, { 3, 2, 1 } },
                3 => new int[,] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } },
                _ => throw new NotImplementedException()
            };
        }

        public static int GetExpectedForFindMaxValue2DimensionalTest(int index)
        {
            return index switch
            {
                0 => 9,
                1 => 9,
                2 => 9,
                3 => 2,
                _ => throw new NotImplementedException()
            };
        }


        public static int[,] GetArrayForFindIndexOfMinValue2DimensionalTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                1 => new int[,] { { 4, 5, 6 }, { 1, 2, 3 }, { 7, 8, 9 } },
                2 => new int[,] { { 4, 5, 6 }, { 7, 8, 9 }, { 3, 2, 1 } },
                3 => new int[,] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } },
                _ => throw new NotImplementedException()
            };
        }

        public static (int, int) GetExpectedForFindIndexOfMinValue2DimensionalTest(int index)
        {
            return index switch
            {
                0 => (0, 0),
                1 => (1, 0),
                2 => (2, 2),
                3 => (0, 0),
                _ => throw new NotImplementedException()
            };
        }

        public static int[,] GetArrayForFindIndexOfMaxValue2DimensionalTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                1 => new int[,] { { 4, 5, 6 }, { 7, 8, 9 }, { 1, 2, 3 } },
                2 => new int[,] { { 9, 8, 1 }, { 4, 5, 6 }, { 3, 2, 1 } },
                3 => new int[,] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } },
                _ => throw new NotImplementedException()
            };
        }

        public static (int, int) GetExpectedForFindIndexOfMaxValue2DimensionalTest(int index)
        {
            return index switch
            {
                0 => (2, 2),
                1 => (1, 2),
                2 => (0, 0),
                3 => (0, 0),
                _ => throw new NotImplementedException()
            };
        }


        public static int[,] GetArrayForGetCountOfElementsGreaterThanNeighboursTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                1 => new int[,] { { 10, 1 }, { 1, 10 } },
                2 => new int[,] { { 10, 1, 10 }, { 1, 10, 1 } },
                3 => new int[,] { { 10, 1, 10 }, { 1, 10, 11 } },
                4 => new int[,] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } },
                _ => throw new NotImplementedException()
            };
        }

        public static int GetExpectedForGetCountOfElementsGreaterThanNeighboursTest(int index)
        {
            return index switch
            {
                0 => 1,
                1 => 2,
                2 => 3,
                3 => 2,
                4 => 0,
                _ => throw new NotImplementedException()
            };
        }

        public static int[,] GetArrayForMirrorArrayAboutMainDiagonalTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } },
                1 => new int[,] { { 9, 1, 7 }, { 3, 8, 2 }, { 4, 6, 2 } },
                2 => new int[,] { { 10, 3 }, { 2, 10 } },
                3 => new int[,] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } },
                4 => new int[,] { { 1 }, { 2} },
                5 => new int[,] { {  } },
                _ => throw new NotImplementedException()
            };
        }

        public static int[,] GetExpectedForMirrorArrayAboutMainDiagonalTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } },
                1 => new int[,] { { 9, 3, 4 }, { 1, 8, 6 }, { 7, 2, 2 } },
                2 => new int[,] { { 10, 2 }, { 3, 10 } },
                3 => new int[,] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } },
                4 => new int[,] { { 1 }, { 2 } },
                5 => new int[,] { { } },
                _ => throw new NotImplementedException()
            };
        }
    }
}
