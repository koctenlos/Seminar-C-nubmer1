Console.Clear();
Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int sq=num2*num2;
Console.WriteLine($"Result: {sq}");

if(sq==num1) {
    Console.WriteLine("yes");
}
else {
    Console.WriteLine("Нет");
}