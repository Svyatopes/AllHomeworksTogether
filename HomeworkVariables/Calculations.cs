using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkVariables
{
    public static class Calculations
    {
        public static double CalculateFirstTask(double numberA, double numberB)
        {
            double calculationResult = (5 * numberA + Math.Pow(numberB, 2)) / (numberB - numberA);
            return calculationResult;
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
    }
}
