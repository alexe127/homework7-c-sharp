//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная).
void fillArray(int[,] arr, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(start, end + 1);
    }
}
void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
}
void replaceRowWithColumns(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i + 1; j < arr.GetLength(1); j++)
            {
                swap(i, j, arr);
            }
        }
        printArray(arr);
    }
    else Console.WriteLine(" Невозможно заменить строки на столбцы (матрица не квадратная) ");
}

void swap(int i, int j, int[,] arr)
{
    int temp = arr[i, j];
    arr[i, j] = arr[j, i];
    arr[j, i] = temp;
}

int m = 7, n = 7;
int[,] array = new int[m, n];
fillArray(array, 10, 99);
printArray(array);
Console.WriteLine();
replaceRowWithColumns(array);