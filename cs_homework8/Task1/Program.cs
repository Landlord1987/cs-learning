Console.WriteLine("Введите размерность массива int m*n через пробел: ");
int[] sizeMatrix = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

Console.WriteLine("Генерируем Random массив от 1 до 99:");

int[,] matrix = FillRandomArray(sizeMatrix);
PrintTwoDimenArray(matrix);

Console.WriteLine();
Console.WriteLine("Отсортированный в обратном порядке массив:");

QuickReverseSortTwoDimen(matrix);
PrintTwoDimenArray(matrix);


//Метод сортирвоки двумерного массива в обратном порядке
void QuickReverseSortTwoDimen(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        int[] arr = Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[i, x])
                    .ToArray();
        
        QuickReverseSort(arr, 0, matrix.GetLength(1) - 1);    
        
        for (int j = 0; j < arr.Length; j++)
        {
            matrix[i, j] = arr[j];
        }
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
//Метод быстрой сортировки в обратном пордке
int[] QuickReverseSort(int[] array, int leftIndex, int rightIndex)
{
    int i = leftIndex;
    int j = rightIndex;
    int pivot = array[leftIndex];
    while (i <= j)
    {
        while (array[i] > pivot)
        {
            i++;
        }

        while (array[j] < pivot)
        {
            j--;
        }
        if (i <= j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }

    if (leftIndex < j)
        QuickReverseSort(array, leftIndex, j);
    if (i < rightIndex)
        QuickReverseSort(array, i, rightIndex);
    return array;
}


