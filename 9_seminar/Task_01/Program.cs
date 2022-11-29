// Задача 1: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


void PrintNumbers(int n)
{
    if (n <= 0)
    {
        return;
    }
    
    System.Console.WriteLine(n);
    PrintNumbers(n-1);
    System.Console.WriteLine(n);
}

PrintNumbers(5);
