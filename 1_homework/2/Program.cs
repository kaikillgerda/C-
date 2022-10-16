// Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.
Console.Write("Пожалуйста, введите первое число ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите второе число ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите третье число ");
int numberThree = Convert.ToInt32(Console.ReadLine());
int max = numberOne;
if (numberTwo > numberOne) max = numberTwo;
if (numberThree > numberTwo) max = numberThree;
Console.WriteLine($"max = {max}");
