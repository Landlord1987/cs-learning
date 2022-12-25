Console.WriteLine("Введите размерность массива int m*n через пробел: ");
int[] sizeMatrix = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

Console.WriteLine("Генерируем Random массив от 1 до 99:");

int[,] matrix = FillRandomArray(sizeMatrix);
PrintTwoDimenArray(matrix);

int minSum;
int[] arrayOfSum;
int row = SmallerAmountOfArrayRows(matrix, out minSum , out arrayOfSum);

Console.WriteLine("Минимальная сумма {0} находится в строке {1}, если считать с 0",minSum, row);

Console.WriteLine();
Console.WriteLine("Вывод сумм всех строк: ");
Console.WriteLine(string.Join("\n", arrayOfSum));

//Метод инициализации двумерного массива
int[,] FillRandomArray(int[] sizeMatrix)
{
    int[,] array = new int[sizeMatrix[0], sizeMatrix[1]];
    Random rnd = new Random();
    for (int i = 0; i < sizeMatrix[0]; i++)
    {
        for (int j = 0; j < sizeMatrix[1]; j++)
        {
            array[i, j] = rnd.Next(1, 100);
        }
    }
    return array;
}

//Метод печати двумерно массива
void PrintTwoDimenArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] arr = Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[i, x])
                    .ToArray();
        Console.WriteLine(string.Join(", ", arr));
    }
}
// Метод расчета суммы элементов одномерного массива
int SumOfElement(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}
//Метод расчета строки с минимальной суммой значений
int SmallerAmountOfArrayRows(int[,] matrix, out int min, out int[] arrayOfSum)
{
    arrayOfSum = new int[matrix.GetLength(0)];
    int[] arr = new int[matrix.GetLength(1)];
    int RowMinSum = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        arr = Enumerable.Range(0, matrix.GetLength(1))
                        .Select(x => matrix[i, x])
                        .ToArray();
        arrayOfSum[i] = SumOfElement(arr);       
    }
    min = arrayOfSum[0];
    for (int j = 1; j < arrayOfSum.Length; j++)
    {
        if (min > arrayOfSum[j])
        {
            min = arrayOfSum[j];
            RowMinSum = j;
        }
    }
    return RowMinSum;
}