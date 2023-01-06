int[] size = new int[2];

while (true)
{
    Console.WriteLine("Введите размер массива M и N через пробел: ");
    size = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
    if (size[0] < 0 || size[1] < 0)
    {
        Console.WriteLine("Вводите значения больше 0");
        continue;
    }
    else break;
}

int[,] arr = FillArraySpiral(size);
PrintTwoDimenArray(arr);

//Метод заполнения массива по спирали
int[,] FillArraySpiral(int[] size)
{
    int countRow1 = 0;
    int countRow2 = 0;
    int countColumn1 = 0;
    int countColumn2 = 0;
    int count = 0;
    int i = 0, j = 0;
    int[,] arr = new int[size[0], size[1]];
    int num = 0;

    for (int k = 0; k < size[0] / 2 + 1; k++)
    {
        for (j = countRow1; j < size[1] - countColumn1; j++) arr[i, j] = ++count;
        j--;
        countRow1++;

        for (i = countRow1; i < size[0] - countRow2; i++) arr[i, j] = ++count;
        i--;
        countColumn1++;

        for (j = size[1] - 1 - countColumn1; j >= 0 + countColumn2; j--) arr[i, j] = ++count;
        j++;
        countRow2++;

        for (i = size[0] - 1 - countRow2; i >= countRow1; i--) arr[i, j] = ++count;
        i++;
        countColumn2++;
    }
    return arr;
}

//Метод печати двумерно массива
void PrintTwoDimenArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write("0" + array[i, j] + ", ");
            else Console.Write(array[i, j] + ", ");
        }
        Console.WriteLine();
    }
}