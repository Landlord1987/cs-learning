Console.WriteLine("Введите размерность квадратных матриц m*n через пробел: ");
int[] sizeMatrix = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

Console.WriteLine("Генерируем Random матрицы со значениями от 1 до 99:");

int[,] matrix1 = FillRandomArray(sizeMatrix);
PrintTwoDimenArray(matrix1);

Console.WriteLine();

int[,] matrix2 = FillRandomArray(sizeMatrix);
PrintTwoDimenArray(matrix2);

Console.WriteLine();

int[,] resMatrix = ProductOfMatrices(matrix1, matrix2);

Console.WriteLine("Результирующая матрица: ");
PrintTwoDimenArray(resMatrix);

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

//Метод инициализации двумерного массива
int[,] FillRandomArray(int[] sizeMatrix)
{
    int[,] array = new int[sizeMatrix[0], sizeMatrix[1]];
    Random rnd = new Random();
    for (int i = 0; i < sizeMatrix[0]; i++)
    {
        for (int j = 0; j < sizeMatrix[1]; j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}
//Метод перемножения матриц
int[,] ProductOfMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] resMatrix = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(0); k++)
            {                                
                resMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resMatrix;
}