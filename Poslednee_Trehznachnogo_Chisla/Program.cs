Console.Clear();
Console.Write("Введите число A: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = N%10;
Console.WriteLine($"Последнее число: {result}");