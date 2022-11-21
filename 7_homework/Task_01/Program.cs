/*Задача 1. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

int Prompt(string message)
{
    Console.Write(message + " -> ");
    return int.Parse(Console.ReadLine());
}

void CreateMatrix(double[,] matr)
{
    Console.WriteLine("Матрица с заданным количеством строк и столбцов создана: ");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(double[,] matr)
{
    int min = Prompt("Пожалуйста, введите минимальное значение элементов матрицы");
    int max = Prompt("Пожалуйста, введите максимальное значение элементов матрицы");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max) + new Random().NextDouble();
            Console.Write($"{matr[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}

void Runner()
{
    int lineLen = Prompt("Пожалуйста, введите количество строк матрицы");
    int columnLen = Prompt("Пожалуйста, введите количество столбцов матрицы");
    double[,] matrix = new double[lineLen, columnLen];
    CreateMatrix(matrix);
    Console.WriteLine();
    FillMatrix(matrix);
}

Runner();