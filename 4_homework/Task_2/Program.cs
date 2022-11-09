// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int NumSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int digit = number % 10;
        sum = sum + digit;
        number = number / 10;
    }
    return sum;
}

int number = Prompt("Введите число: ");
int result = NumSum(number);
Console.WriteLine($"Сумма чисел в числе {number} составляет {result}");