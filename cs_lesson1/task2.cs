Console.WriteLine("Введите день недели числом от 1 до 7: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 > 0 && number1 <=7)
{
switch (number1)
{
    case 1:
        Console.WriteLine("Понедельник");
    break;

    case 2:
        Console.WriteLine("Вторник");
    break;

    case 3:
        Console.WriteLine("Среда");
    break;

    case 4:
        Console.WriteLine("Четверг");
    break;

    case 5:
        Console.WriteLine("Пятница");
    break;

    case 6:
        Console.WriteLine("Суббота");
    break;

    case 7:
        Console.WriteLine("Воскресенье");
    break;
}
}
else {
    Console.WriteLine("Я же просил от 1 до 7! Попробуйте снова");
}