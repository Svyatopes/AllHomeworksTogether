using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class ArrayFunctions
    {
        //it's just upgrage for check stupid input from user
        private static void CheckIndexes(int[] array, ref int startIndex, ref int endIndex)
        {
            if ((array.Length - 1) < endIndex || startIndex > (array.Length - 1))
                throw new IndexOutOfRangeException();

            if (startIndex > endIndex)
            {
                WorkWithVariables.Swap(ref startIndex, ref endIndex);
            }
        }


        /// <summary>
        /// Create array with user defined length and random values in some bounds which defined by user
        /// </summary>
        /// <param name="length">Length of array</param>
        /// <param name="minValue">Minimum possible value of array elements</param>
        /// <param name="maxValue">Maximum possible value of array elements</param>
        /// <returns>New array with random values</returns>
        public static int[] CreateRandomArray(int length, int minValue, int maxValue)
        {
            int[] array = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }
            return array;
        }



        /// <summary>
        /// Create array with user defined length and values from -100 to +100
        /// </summary>
        /// <param name="length">Length of array</param>
        /// <returns>New array with random values</returns>
        public static int[] CreateRandomArray(int length)
        {
            return CreateRandomArray(length, -100, 100);
        }


        /// <summary>
        /// Create array with length is 10 and values from -100 to +100
        /// </summary>
        /// <returns>New array with random values</returns>
        public static int[] CreateRandomArray()
        {
            return CreateRandomArray(10);
        }

        /// <summary>
        /// Create two dimensional array with user defined row and column length and random values 
        /// in some bounds which defined by user
        /// </summary>
        /// <param name="columnLength">Column length of array</param>
        /// <param name="rowLength">Row length of array</param>
        /// <param name="minValue">Minimum possible value of array elements</param>
        /// <param name="maxValue">Maximum possible value of array elements</param>
        /// <returns>New array with random values</returns>
        public static int[,] CreateRandomArray2Dimensional(int columnLength, int rowLength, int minValue, int maxValue)
        {
            int[,] array = new int[columnLength, rowLength];
            Random rnd = new Random();
            for (int i = 0; i < columnLength; i++)
            {
                for (int j = 0; j < rowLength; j++)
                {
                    array[i, j] = rnd.Next(minValue, maxValue);
                }
            }
            return array;
        }


        /// <summary>
        /// Create square array with user defined length and values from -100 to +100
        /// </summary>
        /// <param name="length">Length of array</param>
        /// <returns>New array with random values</returns>
        public static int[,] CreateRandomArray2Dimensional(int length)
        {
            return CreateRandomArray2Dimensional(length, length, -100, 100);
        }


        /// <summary>
        /// Create square array with length is 5 and values from -100 to +100
        /// </summary>
        /// <returns>New array with random values</returns>
        public static int[,] CreateRandomArray2Dimensional()
        {
            return CreateRandomArray2Dimensional(5);
        }


        /// <summary>
        /// Display array in console by 10 items in a row
        /// </summary>
        /// <param name="array">Array to dispay</param>
        public static void ShowArray(int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
                if (((i + 1) % 10) == 0)
                {
                    Console.WriteLine("\r\n");
                }
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Display two dimensional array row by row
        /// </summary>
        /// <param name="array">Array to dispay</param>
        public static void ShowArray(int[,] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }

                Console.WriteLine("\r\n");

            }
            Console.WriteLine();
            Console.WriteLine();
        }


        /// <summary>
        /// Finding minumim element of array
        /// </summary>
        /// <param name="array">Array to find mininum value in array</param>
        /// <param name="startIndex">Starting index to find</param>
        /// <param name="endIndex">Ending index to find</param>
        /// <returns>Minimum element</returns>
        public static int FindMinValue(int[] array, int startIndex, int endIndex)
        {
            CheckIndexes(array, ref startIndex, ref endIndex);

            int minElement = array[startIndex];
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i] < minElement)
                    minElement = array[i];
            }
            return minElement;
        }

        /// <summary>
        /// Найти минимальный элемент массива
        /// </summary>
        /// <param name="array">Array to find mininum value in array</param>
        /// <returns>Minimum element</returns>
        public static int FindMinValue(int[] array)
        {
            return FindMinValue(array, 0, array.Length - 1);
        }


        /// <summary>
        /// Найти минимальный элемент массива
        /// </summary>
        /// <param name="array">Array to find mininum value in array</param>
        /// <returns>Min value in array</returns>
        public static int FindMinValue(int[,] array)
        {
            int minElement = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minElement)
                        minElement = array[i, j];
                }
            }

            return minElement;
        }

        /// <summary>
        /// Найти максимальный элемент массива
        /// </summary>
        /// <param name="array">Array to find maximum value in array</param>
        /// <param name="startIndex">Starting index</param>
        /// <param name="endIndex">Ending index</param>
        /// <returns>Max value in array</returns>
        public static int FindMaxValue(int[] array, int startIndex, int endIndex)
        {
            CheckIndexes(array, ref startIndex, ref endIndex);

            int maxElement = array[startIndex];
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i] > maxElement)
                    maxElement = array[i];
            }
            return maxElement;
        }

        /// <summary>
        /// Найти максимальный элемент массива
        /// </summary>
        /// <param name="array">Array to find maximum value in array</param>
        /// <returns>Max element</returns>
        public static int FindMaxValue(int[] array)
        {
            return FindMaxValue(array, 0, array.Length - 1);
        }


        public static int FindMaxValue(int[,] array)
        {
            int maxElement = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxElement)
                        maxElement = array[i, j];
                }
            }

            return maxElement;
        }


        /// <summary>
        /// Найти индекс минимального элемента массива
        /// </summary>
        /// <param name="array">Array to find index of minimum value in array</param>
        /// <param name="startIndex">Starting index to find</param>
        /// <param name="endIndex">Ending index to find</param>
        /// <returns>Index of minimum value</returns>
        public static int FindIndexOfMinValue(int[] array, int startIndex, int endIndex)
        {
            CheckIndexes(array, ref startIndex, ref endIndex);

            int minElement = array[startIndex];
            int indexOfMinValue = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                    indexOfMinValue = i;
                }
            }
            return indexOfMinValue;
        }

        /// <summary>
        /// Найти индекс минимального элемента массива
        /// </summary>
        /// <param name="array">Array to find index of minimum value in array</param>
        /// <returns>Index of minimum value</returns>
        public static int FindIndexOfMinValue(int[] array)
        {
            return FindIndexOfMinValue(array, 0, array.Length - 1);
        }


        /// <summary>
        /// Finding index of minimum value in two dimensional array
        /// </summary>
        /// <param name="array">Two dimensional array</param>
        /// <returns>Index of minumin value: (row,column)</returns>
        public static (int, int) FindIndexOfMinValue(int[,] array)
        {
            int minElement = array[0, 0];
            int indexOfMinValueColumn = 0;
            int indexOfMinValueRow = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                        indexOfMinValueColumn = j;
                        indexOfMinValueRow = i;
                    }
                }

            }
            return (indexOfMinValueRow, indexOfMinValueColumn);
        }


        /// <summary>
        /// Найти индекс максимального элемента массива
        /// </summary>
        /// <param name="array">Array to find index of maximum value in array</param>
        /// <param name="startIndex">Starting index to find</param>
        /// <param name="endIndex">Ending index to find</param>
        /// <returns>Index of maximum value</returns>
        public static int FindIndexOfMaxValue(int[] array, int startIndex, int endIndex)
        {
            CheckIndexes(array, ref startIndex, ref endIndex);

            int maxElement = array[startIndex];
            int indexOfMaxValue = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    indexOfMaxValue = i;
                }
            }
            return indexOfMaxValue;

        }

        /// <summary>
        /// Найти индекс максимального элемента массива
        /// </summary>
        /// <param name="array">Array to find index of maximum value in array</param>
        /// <returns>Index of maximum value</returns>
        public static int FindIndexOfMaxValue(int[] array)
        {
            return FindIndexOfMaxValue(array, 0, array.Length - 1);
        }

        /// <summary>
        /// Finding index of maximum value in two dimensional array
        /// </summary>
        /// <param name="array">Two dimensional array</param>
        /// <returns>Index of maximum value: (row,column)</returns>
        public static (int, int) FindIndexOfMaxValue(int[,] array)
        {
            int maxElement = array[0, 0];
            int indexOfMaxValueColumn = 0;
            int indexOfMaxValueRow = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                        indexOfMaxValueColumn = j;
                        indexOfMaxValueRow = i;
                    }
                }

            }
            return (indexOfMaxValueRow, indexOfMaxValueColumn);
        }



        /// <summary>
        /// Посчитать сумму элементов массива с нечетными индексами
        /// </summary>
        /// <param name="array">Array to find sum of elements with odd indexes</param>
        /// <returns>Sum of elements with odd indexes</returns>
        public static int SumOfElementsWithOddIndexes(int[] array)
        {
            int index = 0;
            int sumOfElementsWithOddIndex = 0;
            foreach (var elem in array)
            {
                if (index % 2 == 1)
                {
                    sumOfElementsWithOddIndex += elem;
                }
                index++;
            }
            return sumOfElementsWithOddIndex;
        }

        /// <summary>
        /// Сделать реверс массива(массив в обратном направлении)
        /// </summary>
        /// <param name="array">Array to reverse</param>
        /// <returns>New reverse array</returns>
        public static int[] GetNewReversedArray(int[] array)
        {
            int[] reverseArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reverseArray[array.Length - 1 - i] = array[i];
            }
            return reverseArray;
        }

        /// <summary>
        /// Сделать реверс массива(массив в обратном направлении)
        /// </summary>
        /// <param name="array">Array to reverse</param>
        public static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                WorkWithVariables.Swap(ref array[i], ref array[array.Length - 1 - i]);
            }
        }


        /// <summary>
        /// Посчитать количество нечетных элементов массива
        /// </summary>
        /// <param name="array">Array to get count of odd elements in this array</param>
        /// <returns>Count of odd elements in this array</returns>
        public static int GetCountOfOddElements(int[] array)
        {
            int countOfOddElements = 0;
            foreach (var elem in array)
            {
                if (elem % 2 == 1)
                {
                    countOfOddElements++;
                }
            }
            return countOfOddElements;
        }


        /// <summary>
        /// Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        /// </summary>
        /// <param name="array"></param>
        public static void ReplaceLeftAndRightPart(int[] array)
        {
            int startRightPart = array.Length / 2 + array.Length % 2;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int _ = array[i];
                array[i] = array[startRightPart + i];
                array[startRightPart + i] = _;
            }
        }

        /// <summary>
        /// Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором(Select) 
        /// или вставками(Insert)) 
        /// </summary>
        /// <param name="array">Array for sort by Ascending (Bubble)</param>
        public static void SortArrayAsc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        WorkWithVariables.Swap(ref array[j],ref array[j + 1]);
                    }
                }
            }
        }

        /// <summary>
        ///Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :
        ///пузырьком(Bubble), выбором(Select) или вставками(Insert))
        /// </summary>
        /// <param name="array">Array for sort by Ascending (Select)</param>
        public static void SortArrayDesc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexMaxElement = FindIndexOfMaxValue(array, i, array.Length - 1);
                if (indexMaxElement != i)
                {
                    WorkWithVariables.Swap(ref array[i], ref array[indexMaxElement]);
                }
            }
        }


        //        Найти количество элементов массива, которые больше всех своих соседей одновременно

        /// <summary>
        /// Getting count of elements greater than their neighbours
        /// </summary>
        /// <param name="array">Array to count elements</param>
        /// <returns>Count of elements</returns>
        public static int GetCountOfElementsGreaterThanNeighbours(int[,] array)
        {
            int countElementsGreaterNeighbours = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (j + 1 != array.GetLength(1) && array[i, j + 1] >= array[i, j])
                    {
                        continue;
                    }
                    if (j - 1 >= 0 && array[i, j - 1] >= array[i, j])
                    {
                        continue;
                    }
                    if (i + 1 != array.GetLength(0) && array[i + 1, j] >= array[i, j])
                    {
                        continue;
                    }
                    if (i - 1 >= 0 && array[i - 1, j] >= array[i, j])
                    {
                        continue;
                    }

                    countElementsGreaterNeighbours++;

                    //for debug
                    Console.WriteLine($"value: {array[i, j]} index: ({i},{j})");


                }
            }
            return countElementsGreaterNeighbours;

        }

        //Отразите массив относительно его главной диагонали
        /// <summary>
        /// Mirroring two dimensional square array about main diagonal
        /// </summary>
        /// <param name="array">Two dimensional array</param>
        public static void MirrorArrayAboutMainDiagonal(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < array.GetLength(1); j++)
                {
                    WorkWithVariables.Swap(ref array[i, j], ref array[j, i]);
                }
            }
        }
    }
}
