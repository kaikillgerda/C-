//  Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int x1 = Prompt("Введите x1: "), y1 = Prompt("Введите y1: "), z1 = Prompt("Введите y1: ");
int x2 = Prompt("Введите x2: "), y2 = Prompt("Введите y2: "), z2 = Prompt("Введите z1: ");

int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;
double Lenght = Math.Sqrt(x * x + y * y + z * z);

Console.WriteLine($"{Lenght:f2}");
