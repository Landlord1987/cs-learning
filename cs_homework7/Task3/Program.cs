Console.WriteLine("Введите размерность массива int m*n в котором будем искать палиндром!");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
//Первая проверка
//Заполняем массив размером m*n рандомными int значенияями от 100 до 999
int[,] arrayTwoDimen = FillRandomArray(m, n);
//Заполняем массив double средних значений палиндромов столбцов
double[] array = GetArithmeticAveragePalindrome(arrayTwoDimen);
//Выводим на экран массив средних значений стобцов палиндромов и исходный массив
Console.WriteLine("Массив средних значений столбцов палиндромов из рандомных чисел: ");
PrintArray(array);
PrintTwoDimenArray(arrayTwoDimen);

//Вторая проверка
//Заполняем массив вручную int значенияями от 100 до 999
Console.WriteLine("Массив средних значений столбцов палиндромов из заранее введенных чисел: ");
int[,] arrayTwoDimen2 = {
    { 121, 105, 202, 358, 654},
    { 404, 256, 148, 303, 152},
    { 364, 626, 145, 626, 101},
    { 356, 424, 226, 703, 147}
};
//Заполняем массив double средних значений палиндромов столбцов
double[] array2 = GetArithmeticAveragePalindrome(arrayTwoDimen2);
//Выводим на экран массив средних значений стобцов палиндромов и исходный массив
PrintArray(array2);
PrintTwoDimenArray(arrayTwoDimen2);

//Метод возвращает double[] массив средних значений столбцов палиндромов
double[] GetArithmeticAveragePalindrome(int[,] array)
{
    int count, sum;
    double average;
    double[] arr = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        count = 0;
        average = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (array[i, j] % 10 == array[i, j] / 100)
            {
                count++;
                sum += array[i, j];
            }            
        }
        if (count == 0) arr[j] = 0;
        else
        {
            average = (double) sum / count;
            arr[j] = Math.Round(average, 2);
        }
    }
    return arr;
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
            array[i, j] = rnd.Next(100, 1000);
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

//Метод печати одномерного массива
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write(arr[i]);
        else Console.Write("; " + arr[i]);
    }
    Console.Write("]");
}