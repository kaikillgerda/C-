/* Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями

y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int Prompt(string message)
{
    Console.Write(message + " -> ");
    return int.Parse(Console.ReadLine());
}

void Intersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;
    Console.Write($"Точка пересечения прямых имеет координаты X: {x:f1}, Y: {y:f1}");
}

void Runner()
{
    double k1 = Prompt("Пожалуйста, введите значение коэффициента k1, отвечающего за наклон первой прямой");
    double b1 = Prompt("Пожалуйста, введите значение коэффициента b1, отвечающего за смещение первой прямой по оси ординат");
    double k2 = Prompt("Пожалуйста, введите значение коэффициента k2, отвечающего за наклон воторой прямой");
    double b2 = Prompt("Пожалуйста, введите значение коэффициента b2, отвечающего за смещение второй прямой по оси ординат");
    Intersection(k1, b1, k2, b2);
}

Runner();