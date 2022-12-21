Console.WriteLine("Введите размерность массива int m*n из которого будем выбирать число!");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillRandomArray(m, n);

Console.WriteLine("Введите индексы числа в массиве, которое хотите увидеть!");
Console.Write("Введите i: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j: ");
int w = Convert.ToInt32(Console.ReadLine());

PrintNumByIndex(array, k, w);

PrintTwoDimenArray(array);

void PrintNumByIndex(int[,] arr, int i, int j)
{
    if (i > arr.GetLength(0) - 1 || j > arr.GetLength(1) - 1) Console.WriteLine("[{0},{1}]-> Такого числа в массиве нет", i, j);
    else Console.WriteLine("[{0},{1}]-> {2}", i, j, arr[i, j]);
}

//Метод инициализации двумерного массива
int[,] FillRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(1, 100);
        }
    }
    return array;
}
//Метод печати двумерного массива
void PrintTwoDimenArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Массив размером {0}*{1}:", array.GetLength(0), array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write(array[i, j]);
            else Console.Write("; " + array[i, j]);
        }
        Console.Write("]");
        Console.WriteLine();
    }
}