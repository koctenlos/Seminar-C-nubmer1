Console.Clear();
Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;


if (b > a)
    max = b;
if (c > max)
    max = c;

Console.WriteLine($"Максимальное число - {max}");