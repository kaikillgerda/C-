// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int number = new Random().Next(10, 100);

int firstDigit = number / 10;
int lastDigit = number % 10;
if (firstDigit > lastDigit)
{
    Console.WriteLine($"Первая цифра числа {number} большая {firstDigit}");
}
else
{
    Console.WriteLine($"Первая цифра числа {number} большая {lastDigit}");
}