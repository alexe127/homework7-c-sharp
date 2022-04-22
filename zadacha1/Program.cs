// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если заменяет строки на столбцы.
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

void replaseRowWithColumns(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr.GetLength(0) == arr.GetLength(1))
            {
                Console.Write(arr[j, i] + " ");
            }
        Console.WriteLine();
    }

}
bool replase(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr.GetLength(0) == arr.GetLength(1))
            {
                return true;
            }
    }
    return false;
}

int m = 4, n = 4;
int[,] array = new int[m, n];
fillArray(array, 10, 99);
printArray(array);
Console.WriteLine();
if (replase(array)) replaseRowWithColumns(array);
else Console.WriteLine(" невозможно заменить строки на столбцы (матрица не квадратная) ");