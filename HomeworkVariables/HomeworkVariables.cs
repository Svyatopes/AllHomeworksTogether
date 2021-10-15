using System;
using Core;

namespace HomeworkVariables
{
    public class HomeworkVariables
    {
        // Пользователь вводит 2 числа(A и B).Выведите в консоль решение (5 * A + B^2)/(B - A)
        public void SolveFirstTask()
        {
            double numberA;
            double numberB;
            bool needReenterNumbers;
            do
            {
                numberA = UserInputOutput.GetUserNumberDouble("Enter the First number(A):");
                numberB = UserInputOutput.GetUserNumberDouble("Enter the Second number (B):");
                if (numberA == numberB)
                {
                    Console.WriteLine("You have writed the same numbers. Please try again");
                    needReenterNumbers = true;
                }
                else
                {
                    needReenterNumbers = false;
                }

            }
            while (needReenterNumbers);

            double calculationResult = Calculations.CalculateOurTheGreatestFunction(numberA, numberB);

            Console.WriteLine($"Calculation result is: {calculationResult}");
        }


        //Пользователь вводит 2 строковых значения(A и B). Поменяйте содержимое переменных A и B местами.
        public void SolveSecondTask()
        {
            string firstString = UserInputOutput.GetUserString("Enter the First string:");
            string secondString = UserInputOutput.GetUserString("Enter the Second string:");

            WorkWithVariables.Swap(ref firstString, ref secondString);

            Console.WriteLine($"Now first string become: \"{firstString}\" ; and the second one is \"{secondString}\"");
        }



        //Пользователь вводит 2 числа(A и B).Выведите в консоль результат деления A на B и остаток от деления.
        public void SolveThirdTask()
        {
            int numberA = UserInputOutput.GetUserNumberInt("Enter the First number(A):");
            int numberB = UserInputOutput.GetUserNumberIntNotEqualZero("Enter the Second number(B):");

            int divisionResult = Calculations.Divide(numberA, numberB);
            int remainder = Calculations.GetRemainderOfDivide(numberA, numberB);
            Console.WriteLine($"Division result is: {divisionResult} remainder is: {remainder}");
        }


        //Пользователь вводит 3 не равных 0 числа(A, B и С).Выведите в консоль решение(значение X) линейного уравнения стандартного вида, где A* X+B = C.       
        public void SolveFourthTask()
        {
            double numberA = UserInputOutput.GetUserNumberDoubleNotEqualZero("Enter the First number (A):");
            double numberB = UserInputOutput.GetUserNumberDoubleNotEqualZero("Enter the Second number (B):");
            double numberC = UserInputOutput.GetUserNumberDoubleNotEqualZero("Enter the Third number (C):");

            double calculationResult = Calculations.CalculateLinearFunction(numberA, numberB, numberC);
            Console.WriteLine($"The X for this linear function is: {calculationResult}");
        }


        //Пользователь вводит 4 числа(X1, Y1, X2, Y2), описывающие координаты 2 - х точек на координатной плоскости. Выведите уравнение прямой в формате Y = AX + B, проходящей через эти точки.
        public void SolveFifthTask()
        {
            double firstPointX;
            double firstPointY;

            double secondPointX;
            double secondPointY;

            bool needReenterNumbers;

            do
            {
                firstPointX = UserInputOutput.GetUserNumberDouble("Enter the X coordinate for first point:");
                firstPointY = UserInputOutput.GetUserNumberDouble("Enter the Y coordinate for first point:");

                secondPointX = UserInputOutput.GetUserNumberDouble("Enter the X coordinate for second point:");
                secondPointY = UserInputOutput.GetUserNumberDouble("Enter the Y coordinate for second point:");

                if (firstPointX == secondPointX || firstPointY == secondPointY)
                {
                    Console.WriteLine("You need to write points that make line not parallel to Ox or Oy axis. Try again");
                    needReenterNumbers = true;
                }
                else
                {
                    needReenterNumbers = false;
                }

            }
            while (needReenterNumbers);

            string linearFuncString = Calculations.GetLinearFunctionStringBy2Points(firstPointX, firstPointY, secondPointX, secondPointY);
            Console.WriteLine($"The result line function string is: {linearFuncString}");
        }
    }


}
