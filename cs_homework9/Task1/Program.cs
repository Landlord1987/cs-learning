Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNaturalNum(n);

void PrintNaturalNum(int N)
{
    if (N == 1)
    {
        Console.WriteLine(N);
        return;
    }
    else
    {
        Console.Write(N + " ");
        PrintNaturalNum(--N);
    }
}