// Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
Console.Write("Пожалуйста, введите число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}