/*Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */


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

void FindElement(int[,] array, int iNum, int jNum)
{
    int number = array[iNum, jNum];
    if (number == array[iNum, jNum])
    {
        Console.WriteLine($"Искомый элемент: {number}");
    }
}

bool ValidateNumber(int[,] array, int i, int j)
{
    if (i > array.GetLength(0) - 1 || j > array.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента не существует ");
        return false;
    }
    return true;
}


void Runner()
{
    int lineLen = Prompt("Пожалуйста, введите количество строк матрицы");
    int columnLen = Prompt("Пожалуйста, введите количество столбцов матрицы");
    int[,] matrix = new int[lineLen, columnLen];
    CreateMatrix(matrix);
    Console.WriteLine();
    FillMatrix(matrix);
    Console.WriteLine();
    int iNum = Prompt("Введите позицию строки искомого элемента i ");
    int jNum = Prompt("Введите позицию столбца искомого элемента j ");
    if (ValidateNumber(matrix, iNum, jNum))
    {
        FindElement(matrix, iNum, jNum);
    }
}

Runner();