Console.Write("Введите целое первое число: ");

int Num1 = int.Parse(Console.ReadLine() ??"");

Console.Write("Введите второе число: ");

int Num2 = int.Parse(Console.ReadLine() ??"");

/////////////////////////

if (Num2 > Num1)
{
    Console.WriteLine($"{Num2} -> Наибольшее число");
}

else
{
    Console.WriteLine($"{Num1} -> Наибольшее число");
}
