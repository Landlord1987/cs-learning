int[] size = new int[2];

while (true)
{
    Console.WriteLine("Введите два неотрицательных числа M и N через пробел: ");
    size = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
    if (size[0] < 0 || size[1] < 0)
    {
        Console.WriteLine("Вводите только неотрицательные значения");
        continue;
    }
    else break;
}

Console.WriteLine(AckermanFunction(size[0], size[1]));

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}