using NUnit.Framework;
using System;
using System.Linq;

namespace Core.Tests
{
    public class CalculationsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 1, 1)]
        [TestCase(-1, 1, 2)]
        [TestCase(-1, -1, 3)]
        [TestCase(1, -1, 4)]
        public void GetQuarterOfPointTest(int xCoordinate, int yCoordinate, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.GetQuarterOfPoint(xCoordinate, yCoordinate);


            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0, 1)]
        [TestCase(-1, 0)]
        public void GetQuarterOfPointTestNegative(int xCoordinate, int yCoordinate)
        {
            //arrange

            //act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Calculations.GetQuarterOfPoint(xCoordinate, yCoordinate));

            //assert
            Assert.AreEqual("Arguments can't be equal zero", ex.Message);
        }

        [TestCase(1, 2, 1, new double[] { -1.0 })]
        [TestCase(2, -1, -15, new double[] { 3.0, -2.5 })]
        [TestCase(4, 4, 5, new double[] { })]
        [TestCase(1, 0, -25, new double[] { 5.0, -5.0 })]
        [TestCase(1, 1, 0, new double[] { 0.0, -1.0 })]
        public void GetRootsOfSquareFunctionTest(double numberA, double numberB, double numberC, double[] expected)
        {
            //arrange

            //act
            var actualResult = Calculations.GetRootsOfSquareFunction(numberA, numberB, numberC);


            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0, 2, 1)]
        public void GetRootsOfSquareFunctionTestNegative(double numberA, double numberB, double numberC)
        {
            //arrange

            //act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Calculations.GetRootsOfSquareFunction(numberA, numberB, numberC));

            //assert
            Assert.AreEqual("Argument A can't be equal zero, else it's not a square function anymore", ex.Message);
        }

        [TestCase(2, 10, 1024)]
        [TestCase(1, 10, 1)]
        [TestCase(0, 10, 0)]
        [TestCase(1, 0, 1)]
        [TestCase(100, 0, 1)]


        public void PowIntTest(int numberToPower, int power, int expected)
        {
            // arrange

            // act
            int actualResult = Calculations.PowInt(numberToPower, power);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(1, -1)]
        [TestCase(1, -2)]
        public void PowIntTestNegative(int numberToPower, int power)
        {
            //arrange

            //act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Calculations.PowInt(numberToPower, power));

            //assert
            Assert.AreEqual("This method can't power to negative number, so sorry", ex.Message);
        }

        [TestCase(50, 7)]
        [TestCase(25, 4)]
        [TestCase(101, 10)]
        [TestCase(145, 12)]
        [TestCase(144, 11)]


        public void GetCountOfNumbersThatSquareIsLessThanNumberTest(int theNumber, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.GetCountOfNumbersThatSquareIsLessThanNumber(theNumber);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetCountOfNumbersThatSquareIsLessThanNumberTestNegative(int theNumber)
        {
            //arrange

            //act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Calculations.GetCountOfNumbersThatSquareIsLessThanNumber(theNumber));

            //assert
            Assert.AreEqual("The number can't be negative", ex.Message);
        }

        [TestCase(100, 50)]
        [TestCase(101, 1)]
        [TestCase(25, 5)]
        public void GetTheLargestDivisorTest(int theNumber, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.GetTheLargestDivisor(theNumber);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetTheLargestDivisorTestNegative(int theNumber)
        {
            //arrange

            //act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Calculations.GetTheLargestDivisor(theNumber));

            //assert
            Assert.AreEqual("The number can't be negative  or equal zero", ex.Message);
        }

        [TestCase(10, 15, 14)]
        [TestCase(15, 10, 14)]
        [TestCase(-10, -15, -14)]
        [TestCase(-15, -10, -14)]
        [TestCase(0, 0, 0)]
        [TestCase(-6, 6, 0)]
        [TestCase(1, 6, 0)]
        [TestCase(1, 30, 7 + 14 + 21 + 28)]
        public void GetSumOfRangeNumbersDividedBySevenTest(int firstBoundaryRange, int secondBoudaryRange, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.GetSumOfRangeNumbersDividedBySeven(firstBoundaryRange, secondBoudaryRange);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        [TestCase(7, 13)]
        [TestCase(8, 21)]
        public void GetValueOfFibonacciSeriesTest(int indexFibonacciSeries, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.GetValueOfFibonacciSeries(indexFibonacciSeries);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void GetValueOfFibonacciSeriesTestNegative(int indexFibonacciSeries)
        {
            //arrange

            //act assert
            ArgumentException ex = Assert.Throws<ArgumentOutOfRangeException>(() => Calculations.GetValueOfFibonacciSeries(indexFibonacciSeries));

        }

        [TestCase(50, 50, 50)]
        [TestCase(50, 25, 25)]
        [TestCase(100, 102, 2)]
        [TestCase(1, 102, 1)]
        [TestCase(102, 1, 1)]
        [TestCase(-10, -5, 5)]
        [TestCase(-10, -10, 10)]
        public void GetGreatestCommonDivisorTest(int firstNumber, int secondNumber, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.GetGreatestCommonDivisor(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0, 1)]
        [TestCase(1, 0)]
        public void GetGreatestCommonDivisorTestNegative(int firstNumber, int secondNumber)
        {
            //arrange

            //act
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Calculations.GetGreatestCommonDivisor(firstNumber, secondNumber));

            //assert
            Assert.AreEqual("Numbers can't be equal zero", ex.Message);
        }

        [TestCase(27, 3)]
        [TestCase(-27, -3)]
        [TestCase(28, 3)]
        [TestCase(63, 3)]
        [TestCase(64, 4)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        public void GetRootThirdDegreeByHalfDivisionTest(int userCubeNumber, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.GetRootThirdDegreeByHalfDivision(userCubeNumber);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(-1, 1)]
        [TestCase(1111, 4)]
        [TestCase(1001, 2)]
        [TestCase(1321, 3)]
        [TestCase(1320, 2)]
        [TestCase(2320, 1)]
        [TestCase(-2320, 1)]
        public void GetCountOfOddDigitsTest(int userNumber, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.GetCountOfOddDigits(userNumber);

            //assert
            Assert.AreEqual(expected, actualResult);
        }


        [TestCase(2320, 232)]
        [TestCase(123, 321)]
        [TestCase(1501, 1051)]
        [TestCase(8, 8)]
        [TestCase(-100, -1)]
        [TestCase(-10, -1)]
        [TestCase(-12, -21)]
        [TestCase(-203, -302)]
        [TestCase(-2543, -3452)]
        public void GetMirrorNumberTest(int userNumber, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.GetMirrorNumber(userNumber);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(102, 2, true)]
        [TestCase(102, 1, true)]
        [TestCase(100, 2, false)]
        [TestCase(100, 0, true)]
        [TestCase(102, 0, true)]
        [TestCase(-102, 2, true)]
        [TestCase(-102, 1, true)]
        [TestCase(-100, 2, false)]
        [TestCase(-100, 0, true)]
        [TestCase(-102, 0, true)]
        public void IsNumbersHaveSameDigitsTest(int firstNumber, int secondNumber, bool expected)
        {
            //arrange

            //act
            bool actualResult = Calculations.IsNumbersHaveSameDigits(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expected, actualResult);
        }


        [TestCase(-10, -10, 1)]
        [TestCase(10, 10, 1)]
        [TestCase(10, 5, 2)]
        [TestCase(10, 6, 1)]
        [TestCase(0, 6, 0)]
        public void DivideTest(int firstNumber, int secondNumber, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.Divide(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(1, 0)]
        public void DivideTestNegative(int firstNumber, int secondNumber)
        {
            //arrange

            //act assert
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(() => Calculations.Divide(firstNumber, secondNumber));

        }


        [TestCase(-10, -4, -2)]
        [TestCase(10, 10, 0)]
        [TestCase(10, 5, 0)]
        [TestCase(10, 6, 4)]
        [TestCase(0, 6, 0)]
        public void GetRemainderOfDivideTest(int firstNumber, int secondNumber, int expected)
        {
            //arrange

            //act
            int actualResult = Calculations.GetRemainderOfDivide(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(1, 0)]
        public void GetRemainderOfDivideTestNegative(int firstNumber, int secondNumber)
        {
            //arrange

            //act assert
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(() => Calculations.GetRemainderOfDivide(firstNumber, secondNumber));

        }



        [TestCase(2.0, 6.0, 10.0, 2.0)]
        [TestCase(5.0, 22.5, 100.0, 15.5)]
        public void CalculateLinearFunctionTest(double numberA, double numberB, double numberC, double expected)
        {
            //arrange

            //act
            double actualResult = Calculations.CalculateLinearFunction(numberA, numberB, numberC);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0, 1, 1)]
        public void CalculateLinearFunctionTestNegative(double numberA, double numberB, double numberC)
        {
            //arrange

            //act assert
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(() => Calculations.CalculateLinearFunction(numberA, numberB, numberC));

            Assert.AreEqual("Number A can't be equal zero", ex.Message);

        }


        [TestCase(2, 1, 1, 2, -1, 3)]
        [TestCase(1, 2, 3, 4, 1, 1)]
        [TestCase(2, 1, 4, 3, 1, -1)]
        [TestCase(1, 2, 2, 4, 2, 0)]
        [TestCase(1, -2, 2, -4, -2, 0)]
        public void GetLinearFunctionArgumentXAndFreeMemberBy2PointsTest(double firstPointX, double firstPointY, double secondPointX, double secondPointY, double expected, double expected2)
        {
            //arrange

            //act
            (double actualResult, double actualResult2) = Calculations.GetLinearFunctionArgumentXAndFreeMemberBy2Points(firstPointX, firstPointY, secondPointX, secondPointY);

            //assert
            Assert.AreEqual(expected, actualResult);
            Assert.AreEqual(expected2, actualResult2);
        }

        [TestCase(3, 5, 1, 5)]
        [TestCase(5, 4, 5, 3)]
        public void GetLinearFunctionArgumentXAndFreeMemberBy2PointsTestNegative(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            //arrange

            //act assert
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Calculations.GetLinearFunctionArgumentXAndFreeMemberBy2Points(firstPointX, firstPointY, secondPointX, secondPointY));

            Assert.AreEqual("You need to write points that make line not parallel to Ox or Oy axis. Try again", ex.Message);

        }


        [TestCase(1,2,9)]
        [TestCase(0,1,1)]
        [TestCase(1,0,-5)]
        public void CalculateOurTheGreatestFunctionTest(double firstNumber, double secondNumber, double expected)
        {
            //arrange

            //act
            double actualResult = Calculations.CalculateOurTheGreatestFunction(firstNumber, secondNumber);

            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(1, 1)]
        [TestCase(5, 5)]
        [TestCase(0, 0)]
        public void CalculateOurTheGreatestFunctionTestNegative(double firstNumber, double secondNumber)
        {
            //arrange

            //act assert
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(() => Calculations.CalculateOurTheGreatestFunction(firstNumber, secondNumber));
            
            Assert.AreEqual("You cannot enter same numbers for this function", ex.Message);

        }

        [TestCase(100)]
        [TestCase(200)]
        [TestCase(500)]
        [TestCase(-100)]
        public void GetAllNumbersFrom1To1000DividedTest(int userNumber)
        {
            //arrange
            var expected = TestData.GetExpectedListForGetAllNumbersFrom1To1000DividedTest(userNumber);

            //act
            var actualResult = Calculations.GetAllNumbersFrom1To1000Divided(userNumber).ToList();

            //assert
            Assert.AreEqual(expected, actualResult);
        }


        [TestCase(0)]
        public void GetAllNumbersFrom1To1000DividedTestNegative(int userNumber)
        {
            //arrange

            //act assert
            DivideByZeroException ex = Assert.Throws<DivideByZeroException>(() => Calculations.GetAllNumbersFrom1To1000Divided(userNumber).ToList());


            Assert.AreEqual("You cannot divide by zero, obviously", ex.Message);

        }


        [TestCase(10)]
        [TestCase(35)]
        public void GetAllNumbersFrom1ToUserNumberWhereSumEvenDigitsMoreThanOddDigitsTest(int userNumber)
        {
            //arrange
            var expected = TestData.GetExpectedListForGetAllNumbersFrom1ToUserNumberWhereSumEvenDigitsMoreThanOddDigitsTest(userNumber);

            //act
            var actualResult = Calculations.GetAllNumbersFrom1ToUserNumberWhereSumEvenDigitsMoreThanOddDigits(userNumber).ToList();

            //assert
            Assert.AreEqual(expected, actualResult);
        }


        [TestCase(0)]
        [TestCase(-1)]
        public void GetAllNumbersFrom1ToUserNumberWhereSumEvenDigitsMoreThanOddDigitsTestNegative(int userNumber)
        {
            //arrange

            //act assert
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Calculations.GetAllNumbersFrom1ToUserNumberWhereSumEvenDigitsMoreThanOddDigits(userNumber).ToList());


            Assert.AreEqual("The number can't be negative", ex.Message);

        }

    }
}