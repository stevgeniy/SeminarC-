Console.Write("Введите целое число: ");

int Number = int.Parse(Console.ReadLine() ?? "");

/// Начало цикла

int count = 1;
Console.WriteLine("Четные числа: ");

while (count <= Number)
{
        if (count % 2 == 0)
    {
            Console.Write($"{count},");
    }
    count = count + 1;
}
