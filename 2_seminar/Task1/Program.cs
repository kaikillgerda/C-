// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 
// Не использовать строки для расчета.

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 100 || number >= 1000)
    {
        System.Console.WriteLine("Это число не трехзначное");
        return false;
    }
    return true;
}

int number = Prompt("Введите трехзначное число: ");
if (ValidateNumber(number))
{
    int lastDigit = number % 10;
    System.Console.WriteLine($"Последняя цифра числа {number} равна {lastDigit}");
}
