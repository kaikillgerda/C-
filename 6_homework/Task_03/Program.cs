/* Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов.
Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
1 2 3
3 4 5
3+5=8, 1+2+3=6, 8-6=2 */
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

int LineMax(int[,] matr)
{
    Console.Write("Максимальные значения элементов в каждой строке: ");

    int sumLineMax = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int lineMax = matr[i, 0];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > lineMax)
                lineMax = matr[i, j];
        }
        sumLineMax += lineMax;
        Console.Write($"{lineMax} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма максимальных элементов строк: {sumLineMax}");
    return sumLineMax;
}

int ColumnMin(int[,] matr)
{
    Console.Write("Минимальные значения элементов в каждом стролбце: ");

    int sumColumnMin = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        int columnMin = matr[0, j];
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            if (matr[i, j] < columnMin)
                columnMin = matr[i, j];
        }
        sumColumnMin += columnMin;
        Console.Write($"{columnMin} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма минимальных элементов столбцов: {sumColumnMin}");
    return sumColumnMin;
}

void Runner()
{
    int lineLen = Prompt("Пожалуйста, введите количество строк матрицы");
    int columnLen = Prompt("Пожалуйста, введите количество столбцов матрицы");
    int[,] matrix = new int[lineLen, columnLen];
    CreateMatrix(matrix);
    Console.WriteLine();
    FillMatrix(matrix);
    int max = LineMax(matrix);
    Console.WriteLine();
    int min = ColumnMin(matrix);
    Console.WriteLine();
    int result = max - min;
    Console.WriteLine($"Разность сумм максимальных значений строк и минимальных значений столбцов равна: {result}");
}

Runner();