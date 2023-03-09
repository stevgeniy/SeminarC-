Console.Write("Введите первое число: ");

int Num1 = int.Parse(Console.ReadLine() ??"");

Console.Write("Введите второе число: ");

int Num2 = int.Parse(Console.ReadLine() ??"");

Console.Write("Введите третье число: ");

int Num3 = int.Parse(Console.ReadLine() ??"");

int Max = Num1;

if (Num2 > Max)
{
    Max = Num2;
}

if (Num3 > Max)
{
    Max = Num3;
}

Console.WriteLine($"{Max} - > Наибольшее число");
