// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать через функции.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool ValidateNumber(int b)
{
    if (b == 0)
    {
        Console.WriteLine("число 0 не имеет натуральной степени, ЛЮБОЕ ЧИСЛО, ВОЗВЕДЕННОЕ В СТЕПЕНЬ 0 РАВНЯЕТСЯ 1");
        return false;
    }
    return true;
}

int Degree(int a, int b)
{
    int degree = 1;
    int res = a;
    while (degree < Math.Abs(b))
    {
        res = res * a;
        degree++;
    }
    return res;
}

int a = Prompt("Введите первое число: ");
int b = Prompt("Введите второе число: ");

if (ValidateNumber(b))
{
    long result = Degree(a, b);
    Console.WriteLine($"{a} ^ {b} = {result}");
}