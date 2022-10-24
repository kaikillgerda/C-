// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool ValidateCoord(int x, int y)
{
    if (x == 0 || y == 0)
    {
        System.Console.WriteLine("Точка находится на одной из координатных прямых");
        return false;
    }
    return true;
}

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}

int x = Prompt("Введите X => ");
int y = Prompt("Введите Y => ");
if (ValidateCoord(x, y))
{
    int quarter = GetQuarter(x, y);
    System.Console.WriteLine($"Номер четверти = {quarter}");
}
