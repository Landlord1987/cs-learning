Console.Write("Введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;

for(int i = 0; i < n;i++)
{
    Console.Write("M{0}: ", i + 1);
    if (Convert.ToInt32(Console.ReadLine()) > 0) count++;    
}

Console.Write("Больше нуля -> {0} числа", count);




