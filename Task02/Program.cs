/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
(Вывод строки - "под пользователя") */

Task56();

void Task56()
{
    int rows = 5;
    int columns = 3;
    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.WriteLine("Вывод массива");
    PrintArray(array);
    FindRowMinSum(array);
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 20);
        }
    }

}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindRowMinSum(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int minSum = 0;
    int minSumRow = 0;
    for (int j = 0; j < columns; j++) minSum = array[0, j] + minSum;
    for (int i = 1; i < rows; i++)
    {
        int sum = 0;
        for (int k = 0; k < columns; k++) sum = array[i, k] + sum;

        if (sum < minSum)
        {
            minSum = sum;
            minSumRow = i;
        }
    }
    Console.WriteLine("Наименьшая сумма элементов находится в строке " + (minSumRow + 1) + " и равна " + minSum);
}