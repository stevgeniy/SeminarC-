Console.Write("Введите целое число A: ");

int numa = int.Parse(Console.ReadLine() ??"");

Console.Write("Введите целое число B: ");

int numb = int.Parse(Console.ReadLine() ??"");

/////////////////////////

if (numa==numb*numb)
{
    Console.WriteLine($"{numa} -> {numb}  ДА");
}

else
{
    Console.WriteLine($"{numa} -> {numb}  НЕТ");
}
