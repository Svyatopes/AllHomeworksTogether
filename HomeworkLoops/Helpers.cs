using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLoops
{
    public static class Helpers
    {
        public static int GetUserNumberInt(string message)
        {
            bool validNumber;
            int userNumber;
            do
            {
                Console.WriteLine(message);
                string userInput = Console.ReadLine();
                validNumber = int.TryParse(userInput, out userNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);
            return userNumber;
        }

        public static int GetUserNumberIntPositive(string message)
        {
            int userNumber;
            bool needReenterNumbers;
            do
            {
                userNumber = GetUserNumberInt(message);
                if (userNumber <= 0)
                {
                    Console.WriteLine("You have to write positive number. Please try again");
                    needReenterNumbers = true;
                }
                else
                {
                    needReenterNumbers = false;
                }

            }
            while (needReenterNumbers);
            return userNumber;
        }

        public static void PrintAllNumbersFrom1To1000Divided(int divider)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % divider == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void SwapVariables<T>(ref T firstVariable, ref T secondVariable)
        {
            T _ = firstVariable;
            firstVariable = secondVariable;
            secondVariable = _;
        }

        public static void PrintAllNumbersWhereSumEvenDigitsMoreThanOddDigits(int userTypedNumber)
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
                    Console.WriteLine(i);
            }
        }
    }
}
