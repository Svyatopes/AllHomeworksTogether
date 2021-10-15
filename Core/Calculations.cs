using System;
using System.Collections.Generic;

namespace Core
{
    public static class Calculations
    {
        public static int GetQuarterOfPoint(int xCoordinate, int yCoordinate)
        {
            if (xCoordinate > 0)
            {
                if (yCoordinate > 0)
                {
                    return 1;
                }

                return 4;
            }

            if (yCoordinate > 0)
            {

                return 2;
            }

            return 3;
        }

        public static double[] GetRootsOfSquareFunction(double argumentA, double argumentB, double argumentC)
        {
            double discriminant = Math.Pow(argumentB, 2) - 4 * argumentA * argumentC;

            if (discriminant > 0)
            {
                double firstRoot = (-argumentB + Math.Sqrt(discriminant)) / (2 * argumentA);
                double secondRoot = (-argumentB - Math.Sqrt(discriminant)) / (2 * argumentA);
                return new double[] { firstRoot, secondRoot };
            }
            else if (discriminant == 0)
            {
                double root = (-argumentB) / (2 * argumentA);
                return new double[] { root };
            }
            else
            {
                return new double[] { };
            }
        }

        public static double GetSumIfNumberAGraterOrMultiplicationIfEqualOrSubtractionIfLess(double numberA, double numberB)
        {
            if (numberA > numberB)
            {
                return numberA + numberB;
            }
            else if (numberA == numberB)
            {
                return numberA * numberB;
            }
            else
            {
                return numberA - numberB;
            }
        }

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
                        WorkWithVariables.Swap<int>(ref greaterNumber, ref smallerNumber);
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

        public static int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public static int GetRemainderOfDivide(int firstNumber, int secondNumber)
        {
            return firstNumber % secondNumber;
        }

        public static double CalculateLinearFunction(double numberA, double numberB, double numberC)
        {
            return (numberC - numberB) / numberA;
        }

        public static string GetLinearFunctionStringBy2Points(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double argumentX = (secondPointY - firstPointY) / (secondPointX - firstPointX);
            double freeMember = secondPointY - argumentX * secondPointX;

            if (freeMember > 0)
                return $"Y = {argumentX}*X + {freeMember}";
            else
            if (freeMember == 0)
                return $"Y = {argumentX}*X";
            else
                return $"Y = {argumentX}*X - {Math.Abs(freeMember)}";
        }

        /// <summary>
        /// Calculate function: (5 * numberA + numberB^2) / (numberB - numberA)
        /// </summary>
        /// <returns>Calculation result</returns>
        public static double CalculateOurTheGreatestFunction(double numberA, double numberB)
        {
            if (numberA == numberB)
            {
                throw new DivideByZeroException("You cannot enter same numbers for this function");
            }

            double calculationResult = (5 * numberA + Math.Pow(numberB, 2)) / (numberB - numberA);
            return calculationResult;
        }


        public static IEnumerable<int> GetAllNumbersFrom1To1000Divided(int divider)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % divider == 0)
                {
                    yield return i;
                }
            }
        }



        public static IEnumerable<int> GetAllNumbersFrom1ToUserNumberWhereSumEvenDigitsMoreThanOddDigits(int userTypedNumber)
        {
            for (int i = 1; i <= userTypedNumber; i++)
            {

                int sumEvenDigits = 0;
                int sumOddDigits = 0;

                int croppedIndexNumber = i;
                do
                {
                    int lastDigit = croppedIndexNumber % 10;
                    if (lastDigit % 2 == 0)
                    {
                        sumEvenDigits += lastDigit;
                    }
                    else
                    {
                        sumOddDigits += lastDigit;
                    }
                }
                while ((croppedIndexNumber /= 10) != 0);

                if (sumEvenDigits > sumOddDigits)
                    yield return i;
            }
        }
    }
}
