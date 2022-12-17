Console.Write("Для уравнения y = k1 * x + b1 введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Для уравнения y = k1 * x + b1 введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Для уравнения y = k2 * x + b2 введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Для уравнения y = k2 * x + b2 введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = Math.Round((b2 - b1) / (k1-k2), 2); //Вывели и решили уравнение для x
double y = Math.Round(k2 * x + b2, 2); //Решили уравнение для y


if (k1 == k2) Console.WriteLine("Прямые параллельны!");//Проверяем параллельность
else if (k1 * k2 == -1)//Проверяем перпендикулярность
{
    Console.WriteLine("k1={0}, b1={1}, k2={2}, b2={3} --> Точка пересечения ({4}; {5})", k1, b1, k2, b2, x, y);
    Console.WriteLine("Прямые перпендикулярны");
}
else //Считаем угол пересечения и выводим точку и угол пересечения
{
    Console.WriteLine("k1={0}, b1={1}, k2={2}, b2={3} --> Точка пересечения ({4}; {5})", k1, b1, k2, b2, x, y);
    double angle = Math.Round(Math.Abs((k1 - k2) / (1 + k1 * k2) * (180 / Math.PI)), 2);
    if (angle < 90) Console.WriteLine("Прямые пересекаются под углом {0} градусов", angle);
    else Console.WriteLine("Прямые пересекаются под углом {0} градусов", 180 - angle);

}