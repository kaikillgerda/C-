/* Задача 3: Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

bool ValidateMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Умножение таких матриц невозможно!");
        return false;
    }
    return true;
}

void MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Main()
{
    int rowsLength1 = Prompt("Пожалуйста, введите количество строк первой матрицы");
    int columnLength1 = Prompt("Пожалуйста, введите количество столбцов первой матрицы");
    int minValue1 = Prompt("Пожалуйста, введите минимальное значение элементов первой матрицы");
    int maxValue1 = Prompt("Пожалуйста, введите максимальное значение элементов первой матрицы");
    int[,] matrix1 = CreateMatrix(rowsLength1, columnLength1, minValue1, maxValue1);
    int rowsLength2 = Prompt("Пожалуйста, введите количество строк второй матрицы");
    int columnLength2 = Prompt("Пожалуйста, введите количество столбцов второй матрицы");
    int minValue2 = Prompt("Пожалуйста, введите минимальное значение элементов второй матрицы");
    int maxValue2 = Prompt("Пожалуйста, введите максимальное значение элементов второй матрицы");
    int[,] matrix2 = CreateMatrix(rowsLength2, columnLength2, minValue2, maxValue2);
    Console.WriteLine("Первая матрица: ");
    PrintMatrix(matrix1);
    Console.WriteLine("Вторая матрица: ");
    PrintMatrix(matrix2);
    Console.WriteLine("Результат умножения матриц");
    if (ValidateMatrix(matrix1, matrix2))
    {
        MultiplicationMatrix(matrix1, matrix2);
    }
}
Main();