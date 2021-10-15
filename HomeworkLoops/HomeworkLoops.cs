using System;
using Core;

namespace HomeworkLoops
{
    public class HomeworkLoops
    {
        /// <summary>
        /// Пользователь вводит 2 числа(A и B). Возвести число A в степень B.
        /// </summary>
        public void SolveFirstTask()
        {
            int numberToPower = UserInputOutput.GetUserNumberInt("Enter the number to power (A):");
            int power = UserInputOutput.GetUserNumberInt("Enter the power (B):");

            int resultOfPower = Calculations.PowInt(numberToPower, power);

            Console.WriteLine($"The result of power is: {resultOfPower}");

        }

        /// <summary>
        /// Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
        /// </summary>
        public void SolveSecondTask()
        {
            int divider = UserInputOutput.GetUserNumberInt("Enter the Divider:");

            foreach(var number in Calculations.GetAllNumbersFrom1To1000Divided(divider))
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        /// </summary>
        public void SolveThirdTask()
        {
            int theNumber = UserInputOutput.GetUserNumberInt("Enter THE NUMBER:");

            int countOfNumbersThatSquareIsLessThanNumber = Calculations.GetCountOfNumbersThatSquareIsLessThanNumber(theNumber);

            Console.WriteLine($"Count of numbers whose square is less than the NUMBER is: {countOfNumbersThatSquareIsLessThanNumber}");
        }

        /// <summary>
        /// Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        /// </summary>
        public void SolveFourthTask()
        {
            int theNumber = UserInputOutput.GetUserNumberInt("Enter THE NUMBER:");

            int largestDivider = Calculations.GetTheLargestDivisor(theNumber);

            Console.WriteLine($"The largest divider of THE NUMBER is: {largestDivider}");

        }

        /// <summary>
        /// Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, 
        /// которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        /// </summary>
        public void SolveFifthTask()
        {
            int firstBoundaryRange = UserInputOutput.GetUserNumberInt("Enter the first boundary value of range:");
            int secondBoudaryRange = UserInputOutput.GetUserNumberInt("Enter the second boundary value of range:");

            if (firstBoundaryRange == secondBoudaryRange)
            {
                if (firstBoundaryRange % 7 == 0)
                {
                    Console.WriteLine("This range consist of a single value. " +
                        "And its value divided by 7 without remainder");
                    return;
                }
                else
                {
                    Console.WriteLine("This range consist of a single value. " +
                        "And its value DOESN'T divided by 7 without remainder");
                    return;

                }
            }

            if (firstBoundaryRange > secondBoudaryRange)
            {
                WorkWithVariables.Swap(ref firstBoundaryRange, ref secondBoudaryRange);
            }

            int sumOfRangeNumbersDividedBySeven = Calculations.GetSumOfRangeNumbersDividedBySeven(firstBoundaryRange, secondBoudaryRange);
            Console.WriteLine($"The sum of the numbers in this range, which are divisible by 7 " +
                $" without remainder is: {sumOfRangeNumbersDividedBySeven}");
        }


        /// <summary>
        /// Пользователь вводит 1 число(N). Выведите N-ое число ряда фибоначчи.В ряду фибоначчи
        /// каждое следующее число является суммой двух предыдущих. Первое и второе считаются равными 1.
        /// </summary>
        public void SolveSixthTask()
        {
            int indexFibonacciSeries = UserInputOutput.GetUserNumberIntPositive("Enter that number of Fibonacci series that you want to find out");

            int valueOfFibonacciSeries = Calculations.GetValueOfFibonacciSeries(indexFibonacciSeries);

            Console.WriteLine($"Value of {indexFibonacciSeries} term of the Fibonacci series is: {valueOfFibonacciSeries}");

        }

        /// <summary>
        /// Пользователь вводит 2 числа.Найти их наибольший общий делитель используя алгоритм Евклида.
        /// </summary>
        public void SolveSeventhTask()
        {
            int firstNumber = UserInputOutput.GetUserNumberInt("Enter the first number:");
            int secondNumber = UserInputOutput.GetUserNumberInt("Enter the second number:");

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("You typed the same numbers. Next time try another numbers:)");
                return;
            }

            int greatestCommonDivisor = Calculations.GetGreatestCommonDivisor(firstNumber, secondNumber);

            Console.WriteLine($"Greatest common divisor for this numbers is: {greatestCommonDivisor}");
        }

        /// <summary>
        /// Пользователь вводит целое положительное число,
        /// которое является кубом целого числа N. Найдите число N методом половинного деления.
        /// </summary>
        public void SolveEighthTask()
        {
            int usersCubeNumber = UserInputOutput.GetUserNumberIntPositive("Enter the positive number that's have be cube of some number:");

            int rootThirdDegree = Calculations.GetRootThirdDegreeByHalfDivision(usersCubeNumber);

            Console.WriteLine($"If you has writed number that is cube of some number, than you have right answer: {rootThirdDegree}" +
                $"\r\nBut if you has writed wrong number, than root of third degree is something around answer above.");

        }


        /// <summary>
        /// Пользователь вводит 1 число.Найти количество нечетных цифр этого числа.
        /// </summary>
        public void SolveNinthTask()
        {
            int userTypedNumber = UserInputOutput.GetUserNumberInt("Enter THE NUMBER:");

            int countOfOddDigits = Calculations.GetCountOfOddDigits(userTypedNumber);

            Console.WriteLine($"Count of odd digits in {userTypedNumber} is: {countOfOddDigits}");
        }

        /// <summary>
        /// Пользователь вводит 1 число.Найти число, которое является зеркальным отображением 
        /// последовательности цифр заданного числа, например, задано число 123, вывести 321.
        /// </summary>
        public void SolveTenthTask()
        {
            int userTypedNumber = UserInputOutput.GetUserNumberInt("Enter THE NUMBER:");

            int mirrorNumber = Calculations.GetMirrorNumber(userTypedNumber);

            Console.WriteLine($"For typed number: {userTypedNumber}  mirror number is: {mirrorNumber}");
        }


        /// <summary>
        /// Пользователь вводит целое положительное  число (N). 
        /// Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.
        /// </summary>
        public void SolveEleventhTask()
        {
            int userTypedNumber = UserInputOutput.GetUserNumberIntPositive("Enter boarder number to find numbers:");

            foreach (var number in Calculations.GetAllNumbersFrom1ToUserNumberWhereSumEvenDigitsMoreThanOddDigits(userTypedNumber))
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Пользователь вводит 2 числа.Сообщите, есть ли в написании двух чисел одинаковые цифры. 
        /// Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.      
        /// </summary>
        public void SolveTwelvethTask()
        {
            int firstUserNumber = UserInputOutput.GetUserNumberInt("Enter the first number:");
            int secondUserNumber = UserInputOutput.GetUserNumberInt("Enter the second number:");

            if (Calculations.IsNumbersHaveSameDigits(firstUserNumber, secondUserNumber))
            {
                Console.WriteLine("This pair of numbers is have at least one same digit.");
            }
            else
            {
                Console.WriteLine("This pair of numbers is have not same digits.");
            }
        }
    }
}
