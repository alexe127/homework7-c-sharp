// Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента
void fillArray(int[,,] arr)
{
    if (arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2) > 90)
    {
        System.Console.WriteLine("заполнение невозможно");
        return;
    }
    
    int n = 10;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = n++;
                Console.WriteLine($"[{i}][{j}][{k}] = {arr[i, j, k]}");
            }
        }
    }
}

int m = 3, n = 3, l = 3;
int[,,] array = new int[m, n, l];
fillArray(array);

