/* Задача 1: Задайте значения M и N. Напишите программу, 
которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

int Prompt(string message)
{
    Console.Write(message + " -> ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

void PrintNumbers(int m, int n)
{
    if (m <= 0)
    {
        m = 2;
    }
    if (m % 2 != 0)
    {
        m += 1;
    }
    if (n < m && m % 2 == 0)
    {
        return;
    }
    Console.WriteLine(m);
    PrintNumbers(m + 2, n);
}

bool ValidateNumbers(int m, int n)
{
    if (m < 0 && n < 0)
    {
        Console.WriteLine("В введенном диапазоне натуральных чисел нет");
        return false;
    }
    if (n <= m)
    {
        Console.WriteLine("Введенное число n должно быть больше введенного числа m");
        return false;
    }
    return true;
}

void Main()
{
    int m = Prompt("Пожалуйста, введите нижний порог диапазона: число m");
    int n = Prompt("Пожалуйста, введите верхний порог диапазона: число n");
    if (ValidateNumbers(m, n))
    {
        PrintNumbers(m, n);
    }
}
Main();