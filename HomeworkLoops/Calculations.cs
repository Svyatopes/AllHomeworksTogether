using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLoops
{
    public static class Calculations
    {
        public static int PowInt(int numberToPower, int power)
        {
            int resultOfPower = numberToPower;
            for (int i = 1; i < power; i++)
            {
                resultOfPower *= numberToPower;
            }
            return resultOfPower;
        }

        public static int GetCountOfNumbersThatSquareIsLessThanNumber(int theNumber)
        {
            int countOfNumbersThatSquareIsLessThanNumber = 0;

            for (int i = 1; i * i < theNumber; i++)
            {
                if (i * i < theNumber)
                {
                    countOfNumbersThatSquareIsLessThanNumber++;
                }
            }
            return countOfNumbersThatSquareIsLessThanNumber;
        }

        public static int GetTheLargestDivisor(int theNumber)
        {
            for (int i = theNumber - 1; i > 0; i--)
            {
                if (theNumber % i == 0)
                {
                    Console.WriteLine($"Maximum divider of THE NUMBER is: {i}");
                    return theNumber;
                }
            }
            throw new ArithmeticException("Something get wrong:(");
        }

        public static int GetSumOfRangeNumbersDividedBySeven(int firstBoundaryRange, int secondBoudaryRange)
        {
            int sumOfRangeNumbersDividedBySeven = 0;
            for (int i = firstBoundaryRange; i <= secondBoudaryRange; i++)
            {
                if (i % 7 == 0)
                {
                    sumOfRangeNumbersDividedBySeven += i;
                }
            }
            return sumOfRangeNumbersDividedBySeven;
        }

        public static int GetValueOfFibonacciSeries(int indexFibonacciSeries)
        {
            if (indexFibonacciSeries == 1 || indexFibonacciSeries == 2)
            {
                return 1;
            }

            int previousValueFibonacciSeries = 1;
            int currentValueFibonacciSeries = 1;

            for (int i = 2; i < indexFibonacciSeries; i++)
            {
                //NAMING -__________-
                int previousPreviousValueFibonacciSeries = previousValueFibonacciSeries;
                previousValueFibonacciSeries = currentValueFibonacciSeries;

                currentValueFibonacciSeries = previousValueFibonacciSeries + previousPreviousValueFibonacciSeries;

            }
            return currentValueFibonacciSeries;
        }

        public static int GetGreatestCommonDivisor(int firstNumber, int secondNumber)
        {
            int greaterNumber;
            int smallerNumber;

            if (firstNumber > secondNumber)
            {
                greaterNumber = firstNumber;
                smallerNumber = secondNumber;
            }
            else
            {
                greaterNumber = secondNumber;
                smallerNumber = firstNumber;
            }


            int greatestCommonDivisor = 0;
            do
            {

                if (greaterNumber % smallerNumber == 0)
                {
                    greatestCommonDivisor = smallerNumber;
                }
                else
                {
                    greaterNumber %= smallerNumber;
                    if (greaterNumber < smallerNumber)
                    {
                        Helpers.SwapVariables<int>(ref greaterNumber, ref smallerNumber);
                    }
                }

            }
            while (greatestCommonDivisor == 0);

            return greatestCommonDivisor;
        }

        public static int GetRootThirdDegreeByHalfDivision(int usersCubeNumber)
        {
            int leftSide = 0;
            int rightSide = usersCubeNumber;
            int middle;
            long cubeOfMiddle;

            int criticalCountOfLoops = 100;
            do
            {
                middle = (leftSide + rightSide) / 2;
                cubeOfMiddle = (long)middle * middle * middle;

                //For debug
                //Console.WriteLine($"left side: {leftSide} middle: {middle} right side: {rightSide}  cube of middle: {cubeOfMiddle}");

                if (cubeOfMiddle == usersCubeNumber)
                {
                    return middle;
                }

                //for next loop
                if (cubeOfMiddle > usersCubeNumber)
                {
                    rightSide = middle;
                }
                else
                {
                    leftSide = middle;
                }
                criticalCountOfLoops--;
            }
            while (criticalCountOfLoops > 0);
            return middle;
        }

        public static int GetCountOfOddDigits(int userTypedNumber)
        {
            int countOfOddDigits = 0;
            int numberToFindOddDigits = userTypedNumber;
            do
            {
                if (numberToFindOddDigits % 2 == 1)
                    countOfOddDigits++;
            }
            while ((numberToFindOddDigits /= 10) != 0);
            return countOfOddDigits;
        }

        public static int GetMirrorNumber(int userTypedNumber)
        {
            int mirrorNumber = 0;
            int croppedUserNumber = userTypedNumber;
            do
            {
                mirrorNumber *= 10;
                mirrorNumber += croppedUserNumber % 10;
            }
            while ((croppedUserNumber /= 10) != 0);
            return mirrorNumber;
        }

        public static bool IsNumbersHaveSameDigits(int firstUserNumber, int secondUserNumber)
        {
            int firstCroppedNumber = firstUserNumber;
            do
            {
                int lastDigitFirstCroppedNumber = firstCroppedNumber % 10;
                int secondCroppedNumber = secondUserNumber;
                do
                {
                    int lastDigitSecondCroppedNumber = secondCroppedNumber % 10;
                    if (lastDigitFirstCroppedNumber == lastDigitSecondCroppedNumber)
                    {
                        return true;
                    }
                }
                while ((secondCroppedNumber /= 10) != 0);
            }
            while ((firstCroppedNumber /= 10) != 0);
            return false;
        }

    }
}
