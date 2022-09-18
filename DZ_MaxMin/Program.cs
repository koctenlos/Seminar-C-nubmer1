Console.Clear();
Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1>num2){
    Console.WriteLine($"Максимальное число - {num1}");
}
else{
    Console.WriteLine($"Максимальное число - {num2}");
}
if(num1<num2){
    Console.WriteLine($"Миниимальное число - {num1}");
}
else{
    Console.WriteLine($"Минимальное число - {num2}");
}