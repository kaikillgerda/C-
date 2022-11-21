/* Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3 */

int Prompt(string message)
{
    Console.Write(message + " -> ");
    return int.Parse(Console.ReadLine());
}

void CreateMatrix(int[,] matr)
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

void FillMatrix(int[,] matr)
{
    int min = Prompt("Пожалуйста, введите минимальное значение элементов матрицы");
    int max = Prompt("Пожалуйста, введите максимальное значение элементов матрицы");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max);
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ColumnAverage(int[,] matr)
{
    Console.Write("Среднее арифметическое в каждом столбце: ");

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double columnAverage = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            columnAverage += matr[i, j];
        }
        Console.Write(columnAverage/ matr.GetLength(1) + " ");
    }
}

void Runner()
{
    int lineLen = Prompt("Пожалуйста, введите количество строк матрицы");
    int columnLen = Prompt("Пожалуйста, введите количество столбцов матрицы");
    int[,] matrix = new int[lineLen, columnLen];
    CreateMatrix(matrix);
    Console.WriteLine();
    FillMatrix(matrix);
    ColumnAverage(matrix);
}

Runner();