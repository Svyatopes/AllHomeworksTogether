using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class UserInputOutput
    {

        public static string GetUserString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

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

        public static int GetUserNumberIntWith2Digits(string message)
        {
            bool needReenterNumbers;
            int userNumberWith2Digits;
            do
            {
                userNumberWith2Digits = GetUserNumberInt("Enter 2-digits number:");

                if (userNumberWith2Digits > 99 || userNumberWith2Digits < 10)
                {
                    Console.WriteLine("This number is not valid.");
                    needReenterNumbers = true;
                }
                else
                {
                    needReenterNumbers = false;
                }
            }
            while (needReenterNumbers);
            return userNumberWith2Digits;
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





        
    }
}
