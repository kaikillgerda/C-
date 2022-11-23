/* Задача 1: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

void ArrangeRowsNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, j] > matrix[i, k])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine())
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
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
    ArrangeRowsNumbers(matrix);
}
Main();