// Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все
//  чётные числа от 1 до N.
Console.Write("Пожалуйста, введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int num = 2;
while (num < n-1)
{
    if (num % 2 == 0) Console.Write($"{num}, ");
    num = num + 2;
} 
Console.Write(num);