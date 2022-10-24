//  Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 10000 || number > 100000)
    {
        Console.WriteLine("Пожалуйста, следуйте условиям задачи, введите пятизначное число: ");
        return false;
    }
    return true;
}

int number = Prompt("Пожалуйста, введите пятизначное число: ");
if (ValidateNumber(number))
{
    if ((number % 10 == number / 10000) && (number % 100 / 10 == number / 1000 % 10) && (number % 1000 / 100 == number / 100 % 10))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}