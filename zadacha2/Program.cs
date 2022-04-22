// Найти произведение двух матриц
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
int[,] changeArray(int[,] arr, int[,] arr1)
{

    int[,] arr2 = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr.GetLength(0) == arr1.GetLength(0) && arr.GetLength(1) == arr1.GetLength(1))
                arr2[i, j] = arr[i, j] * arr1[i, j];
    }
    return arr2;
    
}
bool replase(int[,] arr, int[,] arr1)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr.GetLength(0) == arr1.GetLength(0) && arr.GetLength(1) == arr1.GetLength(1))
            {
                return true;
            }
    }
    return false;
}


int m = 3, n = 3;
int[,] array = new int[m, n];
int k = 3, l = 3;
int[,] array1 = new int[k, l];

fillArray(array, 1, 3);
fillArray(array1, 1, 3);
Console.WriteLine($"матрица1: ");
printArray(array);
Console.WriteLine();
Console.WriteLine($"матрица2: ");
printArray(array1);
Console.WriteLine();
int[,] result = changeArray(array, array1);
Console.WriteLine($"Произведение двух матриц = ");
if (replase(array,array1)) printArray(result);
else Console.WriteLine(" невозможно умножить матрицы (матрица не квадратная) ");

