Console.WriteLine("Введите размерность массива int m*n через пробел (но не более чем 9*10): ");
int[] sizeMatrix = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

Console.WriteLine("Генерируем Random массив уникальных чисел от 1 до 99:");

int[,] matrix = FillRandomUniqMatrix(sizeMatrix);
PrintTwoDimenArray(matrix);

// Метод инициализации двумерного массива
int[,] FillRandomUniqMatrix(int[] sizeMatrix)
{
    int[,] array = new int[sizeMatrix[0], sizeMatrix[1]];    
    Random rnd = new Random();
    array[0,0] = rnd.Next(1,10);    
    int tmp = 0;
    for (int i = 0; i < sizeMatrix[0]; i++)
    {
        for (int j = 0; j < sizeMatrix[1]; j++)
        {
            if (i == 0 && j == 0) continue;
            tmp = rnd.Next(1, 100);           
            if (CheckDuplicateElements(array, tmp)) j--;            
            else array[i, j] = tmp;
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

//Метод проверки на дубли
bool CheckDuplicateElements(int[,] matrix, int num)
{   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] == num) return true;
        }        
    }
    return false;    
}