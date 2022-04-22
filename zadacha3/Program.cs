// Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента
void fillArray(int[,,] arr)
{
    int n = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (n >= 10 && n < 100)
                    arr[i, j, k] = n;
                n++;
            }
    }
}
void printArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)            
                Console.Write(arr[i, j, k] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void prinIndextArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
                Console.WriteLine($"[{i}][{j}][{k}] = {arr[i, j, k]}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int m = 3, n = 3, l = 3;
int[,,] array = new int[m, n, l];
fillArray(array);
printArray(array);
prinIndextArray(array);
