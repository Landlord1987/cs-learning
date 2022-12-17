Console.WriteLine("Cумма произведений пар чисел в одномерном целочисленном массиве:");
int[] arr1 = { 1, 3, 8, 3, 2 };
int[] arr2 = { 8, 3, 4, 2 };
int[] arr3 = { 8, 3, 4, 2, 6, 6, 5 };

PrintArray(arr1);
SumOfproductsOfpairsOfnum(arr1);

PrintArray(arr2);
SumOfproductsOfpairsOfnum(arr2);

PrintArray(arr3);
SumOfproductsOfpairsOfnum(arr3);

//Метод вычисления суммы произведений пар чисел в одномерном целочисленном массиве
void SumOfproductsOfpairsOfnum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        sum += array[i]* array[array.Length - i - 1];
    }
    Console.WriteLine(" Сумма произведенияя пар чисел = {0}", sum);
}

//Метод печати массива
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write(arr[i]);
        else Console.Write(", " + arr[i]);
    }
    Console.Write("]");
}