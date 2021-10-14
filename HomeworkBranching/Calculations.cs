using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkBranching
{
    public static class Calculations
    {
        public static double CalculateFirtsTask(double numberA, double numberB)
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

        public static double[] GetRootsOfSquareFunction(double argumentA,double argumentB, double argumentC)
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
    }
}
