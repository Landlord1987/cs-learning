int[] size = new int[2];

while (true)
{
    Console.WriteLine("Задайте значения M и N через пробел: ");
    size = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
    if (size[0] <= 0 || size[1] <= 0)
    {
        Console.WriteLine("Вводите значения только больше 0");
        continue;
    }
    else break;
}

Console.WriteLine(SumOfElements(size[1]));

int SumOfElements(int elements)
{
    int sum = elements;
    if (elements == size[0]) return elements;
    else
    {
        sum += SumOfElements(--elements);
    }
    return sum;
}