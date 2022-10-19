// Напишите программу, которая выводит третью цифру ЗАДАННОГО числа 
// или сообщает, что третьей цифры нет. Не использовать строки для расчета.
int number = 326792;
if (number >= 100)
{
    while ((number/100) > 9)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
