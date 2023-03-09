

Console.Write("Введите номер дня недели от 1 до 7: ");

int userDay = int.Parse(Console.ReadLine() ?? "");

if (userDay == 1)
{
    Console.WriteLine("Понедельник");
}

else if (userDay == 2)
{
    Console.WriteLine("Вторник");
}

else if (userDay == 3)
{
    Console.WriteLine("Среда");
}

else if (userDay == 4)
{
    Console.WriteLine("Четверг");
}

else if (userDay == 5)
{
    Console.WriteLine("Пятница");
}

else if (userDay == 6)
{
    Console.WriteLine("Суббота");
}

else if (userDay == 7)
{
    Console.WriteLine("Воскресенье");
}

else
{
    Console.WriteLine("Неверноое число");
}
