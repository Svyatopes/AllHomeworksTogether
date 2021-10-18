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

        public static List<int> GetExpectedListForGetAllNumbersFrom1ToUserNumberWhereSumEvenDigitsMoreThanOddDigitsTest(int enteredNumber)
        {
            return enteredNumber switch
            {
                10 => new List<int>() { 2, 4, 6, 8 },
                35 => new List<int>() { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34 },
                _ => throw new NotImplementedException()
            };
        }
    }
}
