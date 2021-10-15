using System;
using Core;

namespace HomeworkBranching
{
    public class HomeworkBranching
    {
        /// <summary>
        /// Пользователь вводит 2 числа(A и B). Если A>B, подсчитать A+B, если A = B, подсчитать A* B, если A меньше B, подсчитать A-B.
        /// </summary>
        public void SolveFirstTask()
        {
            double numberA = UserInputOutput.GetUserNumberDouble("Enter number A:");
            double numberB = UserInputOutput.GetUserNumberDouble("Enter number B:");

            double calculationResult = Calculations.GetSumIfNumberAGraterOrMultiplicationIfEqualOrSubtractionIfLess(numberA, numberB);

            Console.WriteLine($"Calculation result is: {calculationResult}");

        }

        /// <summary>
        /// Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами(X, Y).
        /// </summary>
        public void SolveSecondTask()
        {
            int xCoordinate = UserInputOutput.GetUserNumberIntNotEqualZero("Enter X coordinate: ");
            int yCoordinate = UserInputOutput.GetUserNumberIntNotEqualZero("Enter Y coordinate:");

            string quarterString = FromValuesToString.GetStringOfQuarter(Calculations.GetQuarterOfPoint(xCoordinate, yCoordinate));
            Console.WriteLine($"Your point is on {quarterString} quarter.");
        }


        /// <summary>
        /// Пользователь вводит 3 числа(A, B и С). Выведите их в консоль в порядке возрастания.
        /// </summary>
        public void SolveThirdTask()
        {
            double numberA = UserInputOutput.GetUserNumberDouble("Enter number A:");
            double numberB = UserInputOutput.GetUserNumberDouble("Enter number B:");
            double numberC = UserInputOutput.GetUserNumberDouble("Enter number C:");

            string threeNumbersStringSortByAsc = FromValuesToString.GetStringOfThreeNumberSortByAsc(numberA, numberB, numberC);
            Console.WriteLine($"This thee numbers sort by Ascending: {threeNumbersStringSortByAsc}");
        }

        /// <summary>
        /// Пользователь вводит 3 числа(A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.
        /// </summary>
        public void SolveFourthTask()
        {
            double numberA = UserInputOutput.GetUserNumberDouble("Enter number A:");
            double numberB = UserInputOutput.GetUserNumberDouble("Enter number B:");
            double numberC = UserInputOutput.GetUserNumberDouble("Enter number C:");

            double[] roots = Calculations.GetRootsOfSquareFunction(numberA, numberB, numberC);
            
            if(roots.Length == 0)
            {
                Console.WriteLine("We don't have any real roots in this function");
                return;
            }

            Console.WriteLine("For this function we have finded this roots: ");
            foreach(var root in roots)
            {
                Console.WriteLine(root);
            }

        }

        /// <summary>
        /// Пользователь вводит двузначное число.Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
        /// </summary>
        public void SolveFifthTask()
        {
            int numberToTranscription = UserInputOutput.GetUserNumberIntWith2Digits("Enter 2-digits number:");

            string resultTranscriptionString = FromValuesToString.GetTranscriptionOf2DigitsInt(numberToTranscription);

            Console.WriteLine($"Transcription of your digits is: {resultTranscriptionString}");
        }
    }
}
