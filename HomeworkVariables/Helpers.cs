using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkVariables
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

        public static int GetUserNumberIntNotEqualZero(string message)
        {
            int userNumber;
            bool needReenterNumbers;
            do
            {
                userNumber = GetUserNumberInt(message);
                if (userNumber == 0)
                {
                    Console.WriteLine("You have write zero. You can't input zero in this task. Please try again");
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

        public static double GetUserNumberDouble(string message)
        {
            bool validNumber;
            double userNumber;
            do
            {
                Console.WriteLine(message);
                string userInput = Console.ReadLine();
                validNumber = double.TryParse(userInput, out userNumber);
                if (!validNumber)
                {
                    Console.WriteLine($"You typed something wrong, try again.");
                }
            }
            while (!validNumber);
            return userNumber;
        }

        public static double GetUserNumberDoubleNotEqualZero(string message)
        {
            double userNumber;
            bool needReenterNumbers;
            do
            {
                userNumber = GetUserNumberDouble(message);
                if (userNumber == 0.0)
                {
                    Console.WriteLine("You have write zero. You can't input zero in this task. Please try again");
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




        public static string GetUserString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void SwapVariables<T>(ref T firstVariable, ref T secondVariable)
        {
            T _ = firstVariable;
            firstVariable = secondVariable;
            secondVariable = _;
        }
    }
}
