/* Задача 2: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int Prompt(string message)
{
    Console.Write(message + " -> ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateMatrix(int rowsLength, int columnLength, int minValue, int maxValue)
{
    int[,] tempMatrix = new int[rowsLength, columnLength];
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void LineSum(int[,] matrix)
{
    int lineSum1 = 0, row = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        lineSum1 += matrix[0, i];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int lineSum2 = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            lineSum2 += matrix[i, j];
        }
        if (lineSum1 > lineSum2)
        {
            lineSum1 = lineSum2;
            row = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов составляет: {lineSum1}\nНаходится в строке: {row + 1} ");
}

void Main()
{
    int rowsLength = Prompt("Пожалуйста, введите количество строк матрицы");
    int columnLength = Prompt("Пожалуйста, введите количество столбцов матрицы");
    int minValue = Prompt("Пожалуйста, введите минимальное значение элементов матрицы");
    int maxValue = Prompt("Пожалуйста, введите максимальное значение элементов матрицы");
    int[,] matrix = CreateMatrix(rowsLength, columnLength, minValue, maxValue);
    PrintMatrix(matrix);
    Console.WriteLine();
    LineSum(matrix);
}
Main();