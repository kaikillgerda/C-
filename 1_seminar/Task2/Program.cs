// Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да
Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine()); 

Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());

if(a * a == b)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
