/* Задайте двумерный массив. Напишите программу,
 которая упорядочит по убыванию элементы каждой строки двумерного массива. */

Task54();

void Task54()
{
    Random random = new Random();
    int rows = random.Next(4, 10);
    int columns = random.Next(4, 10);
    int[,] array = new int[rows, columns];
    FillArray(array);
    Console.WriteLine("Вывод массива");
    PrintArray(array);
    Console.WriteLine("Упорядоченный массив");
    OrderedArray(array);
    PrintArray(array);
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
            array[i, j] = random.Next(-50, 51);
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

void OrderedArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = j + 1; k < columns; k++)
            if (array [i, k] > array [i, j]) (array[i, j], array[i, k]) = (array[i,k], array [i,j]);
        }

    }
}