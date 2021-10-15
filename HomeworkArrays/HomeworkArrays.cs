using System;
using Core;

namespace HomeworkArrays
{
    public class HomeworkArrays
    {

        //Найти минимальный элемент массива
        public void SolveFirstTask1DimensionalArray()
        {
            int[] array = ArrayFunctions.CreateRandomArray(10);
            ArrayFunctions.ShowArray(array);

            int minValue = ArrayFunctions.FindMinValue(array);
            Console.WriteLine($"Minimum value of this array is: {minValue}");
        }

        //Найти максимальный элемент массива
        public void SolveSecondTask1DimensionalArray()
        {
            int[] array = ArrayFunctions.CreateRandomArray(10);
            ArrayFunctions.ShowArray(array);

            int maxValue = ArrayFunctions.FindMaxValue(array);
            Console.WriteLine($"Maximum value of this array is: {maxValue}");
        }


        //Найти индекс минимального элемента массива
        public void SolveThirdTask1DimensionalArray()
        {
            int[] array = ArrayFunctions.CreateRandomArray(10);
            ArrayFunctions.ShowArray(array);

            int indexOfMinValue = ArrayFunctions.FindIndexOfMinValue(array);
            Console.WriteLine($"Index of minimum value of this array is: {indexOfMinValue}");
        }

        //Найти индекс максимального элемента массива
        public void SolveFourthTask1DimensionalArray()
        {
            int[] array = ArrayFunctions.CreateRandomArray(10);
            ArrayFunctions.ShowArray(array);

            int indexOfMaxValue = ArrayFunctions.FindIndexOfMaxValue(array);
            Console.WriteLine($"Index of maximum value of this array is: {indexOfMaxValue}");
        }


        //Посчитать сумму элементов массива с нечетными индексами
        public void SolveFifthTask1DimensionalArray()
        {
            int[] array = ArrayFunctions.CreateRandomArray(10);
            ArrayFunctions.ShowArray(array);

            int indexOfMaxValue = ArrayFunctions.FindIndexOfMaxValue(array);
            Console.WriteLine($"Index of maximum value of this array is: {indexOfMaxValue}");
        }

        //Сделать реверс массива(массив в обратном направлении)
        public void SolveSixthTask1DimensionalArray()
        {
            int[] array = ArrayFunctions.CreateRandomArray(10);
            Console.WriteLine("CREATED ARRAY:");
            ArrayFunctions.ShowArray(array);

            ArrayFunctions.ReverseArray(array);
            Console.WriteLine("REVERSED ARRAY:");
            ArrayFunctions.ShowArray(array);
        }

        //Посчитать количество нечетных элементов массива
        public void SolveSeventhTask1DimensionalArray()
        {
            int[] array = ArrayFunctions.CreateRandomArray(10);
            ArrayFunctions.ShowArray(array);

            int countOfOddElements = ArrayFunctions.GetCountOfOddElements(array);
            Console.WriteLine($"Count of odd elements in this array is: {countOfOddElements}");
        }

        //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        public void SolveEighthTask1DimensionalArray()
        {
            int[] array = ArrayFunctions.CreateRandomArray(10);
            Console.WriteLine("CREATED ARRAY:");
            ArrayFunctions.ShowArray(array);

            ArrayFunctions.ReplaceLeftAndRightPart(array);
            Console.WriteLine("ARRAY WITH REPLACED LEFT AND RIGHT PART:");
            ArrayFunctions.ShowArray(array);
        }

        //Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble), выбором(Select) или вставками(Insert)) 
        public void SolveNinthTask1DimensionalArray()
        {
            int[] array = ArrayFunctions.CreateRandomArray(10);
            Console.WriteLine("CREATED ARRAY:");
            ArrayFunctions.ShowArray(array);

            ArrayFunctions.SortArrayAsc(array);
            Console.WriteLine("ARRAY SORTED ASCENDING:");
            ArrayFunctions.ShowArray(array);
        }

        //Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором(Select) или вставками(Insert))
        public void SolveTenthTask1DimensionalArray()
        {
            int[] array = ArrayFunctions.CreateRandomArray(10);
            Console.WriteLine("CREATED ARRAY:");
            ArrayFunctions.ShowArray(array);

            ArrayFunctions.SortArrayDesc(array);
            Console.WriteLine("ARRAY SORTED DESCENDING:");
            ArrayFunctions.ShowArray(array);
        }


        //Найти минимальный элемент массива
        public void SolveFirstTask2DimensionalArray()
        {
            int[,] array = ArrayFunctions.CreateRandomArray2Dimensional(10);
            ArrayFunctions.ShowArray(array);

            int minValue = ArrayFunctions.FindMinValue(array);
            Console.WriteLine($"Minimum value of this array is: {minValue}");
        }

        //Найти максимальный элемент массива
        public void SolveSecondTask2DimensionalArray()
        {
            int[,] array = ArrayFunctions.CreateRandomArray2Dimensional(10);
            ArrayFunctions.ShowArray(array);

            int maxValue = ArrayFunctions.FindMaxValue(array);
            Console.WriteLine($"Maximum value of this array is: {maxValue}");
        }


        //Найти индекс минимального элемента массива
        public void SolveThirdTask2DimensionalArray()
        {
            int[,] array = ArrayFunctions.CreateRandomArray2Dimensional(10);
            ArrayFunctions.ShowArray(array);

            (int indexRowOfMinValue, int indexColumnOfMinValue) = ArrayFunctions.FindIndexOfMinValue(array);
            Console.WriteLine($"Index of minimum value of this array is: ({indexRowOfMinValue},{indexColumnOfMinValue})");
        }

        //Найти индекс максимального элемента массива
        public void SolveFourthTask2DimensionalArray()
        {
            int[,] array = ArrayFunctions.CreateRandomArray2Dimensional(10);
            ArrayFunctions.ShowArray(array);

            (int indexRowOfMaxValue, int indexColumnOfMaxValue) = ArrayFunctions.FindIndexOfMaxValue(array);
            Console.WriteLine($"Index of minimum value of this array is: ({indexRowOfMaxValue},{indexColumnOfMaxValue})");
        }

        //Найти количество элементов массива, которые больше всех своих соседей одновременно
        public void SolveFifthTask2DimensionalArray()
        {
            int[,] array = ArrayFunctions.CreateRandomArray2Dimensional(5);
            ArrayFunctions.ShowArray(array);

            int countOfElementsGreaterThanNeighbours = ArrayFunctions.GetCountOfElementsGreaterThanNeighbours(array);
            Console.WriteLine($"Count of elements which value is greater than their neighbours: {countOfElementsGreaterThanNeighbours}");
        }

        //Отразите массив относительно его главной диагонали
        public void SolveSixthTask2DimensionalArray()
        {
            int[,] array = ArrayFunctions.CreateRandomArray2Dimensional(7);
            Console.WriteLine("CREATED ARRAY:");
            ArrayFunctions.ShowArray(array);

            ArrayFunctions.MirrorArrayAboutMainDiagonal(array);
            Console.WriteLine("ARRAY WITH MIRRORED VALUES ABOUT MAIN DIAGONAL:");
            ArrayFunctions.ShowArray(array);
        }

    }
}
