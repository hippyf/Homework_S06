/*   Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1  2  3  4
12 13 14 5
11 16 15 6
10  9  8  7  */

Task58();

void Task58()
{
    int rows = 4;
    int columns = 4;
    int[,] array = new int[rows, columns];
    FillArraySpirally(array);
    Console.WriteLine("Вывод массива");
    PrintArray(array);
}

void FillArraySpirally(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int element = 1;
    for (int i = 0; i < columns; i++ ) 
    {
        array[0,i] = element;
        element++;
    }
    for (int j = 1; j < rows; j++)
    {
        array[j, columns-1] = element;
        element++;
    }
    for (int k = columns-2; k >= 0; k-- ) 
    {
        array[3,k] = element;
        element++;
    }
    for (int l = rows-2; l >0; l--)
    {
        array[l, 0] = element;
        element++;
    }
    for (int m = columns-3; m < columns -1; m++ ) 
    {
        array[1,m] = element;
        element++;
    }
    for (int n = columns-2; n > 0; n-- ) 
    {
        array[2,n] = element;
        element++;
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
