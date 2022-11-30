/* Задача 2: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */

int Prompt(string message)
{
    Console.Write(message + " -> ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int PrintNumbers(int m, int n)
{
    if (m <= 0)
    {
        m = 1;
    }
    if (n < m)
    {
        return 0;
    }
    return (m + PrintNumbers(m + 1, n));
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
        Console.WriteLine(PrintNumbers(m, n));
    }
}
Main();
