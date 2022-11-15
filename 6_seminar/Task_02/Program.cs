// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.
int Prompt(string msg)
{
    Console.WriteLine(msg);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

bool IsItTriangle (int x, int y, int z)
{
    return x+y > z;
}

void Execute()
{
    int num1 = Prompt("Enter side of triangle 1");
    int num2 = Prompt("Enter Enter side of triangle 2");
    int num3 = Prompt("Enter Enter side of triangle 3");
    if(IsItTriangle(num1, num2, num3)&&IsItTriangle(num2, num3, num1) && IsItTriangle(num3, num1, num2))
    {
        Console.WriteLine("The triangle exists");
    }
    else
    {
        Console.WriteLine("The triangle doesn't exist");
    }
}
Execute();
