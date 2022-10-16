// Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Пожалуйста, введите первое число ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите второе число ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne > numberTwo)
{
    Console.WriteLine($"max = {numberOne}");
    Console.WriteLine($"min = {numberTwo}");
}
else
{
    Console.WriteLine($"max = {numberTwo}");
    Console.WriteLine($"min = {numberOne}");
}