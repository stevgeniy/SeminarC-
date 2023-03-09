Console.Write("Введите целое число: ");

int Num1 = int.Parse(Console.ReadLine() ??"");


if (Num1%2 == 0)
{
    Console.WriteLine($"{Num1} -> Четное");
}

else
{
    Console.WriteLine($"{Num1} -> Нечетное");
}