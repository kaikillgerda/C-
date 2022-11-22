//Задача 3: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных. Значения элементов массива 0..9


int GetRandomInt(int minRandom, int maxRandom)  //возвращает целое число из диапазона [minRandom;maxRandom)
{
    return new Random().Next(minRandom, maxRandom);
}

int[,] CreateRandomMatrixInt(int rows, int columns, int minRandom = 0, int maxRandom = 10)   //возвращает случайную матрицу заданной размерности
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = GetRandomInt(minRandom, maxRandom);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)  //Выводит на экран содержимое матрицы

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.Write("\n");
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}

int[] GetFreqDictionary(int[,] matrix)
{
    int[] freqArray = new int[10];
    foreach (var item in matrix)
    {
        freqArray[item]++;
    }
    return freqArray;
}

int[,] matrix = CreateRandomMatrixInt(5, 5, 0, 10);
PrintMatrix(matrix);
int[] freqArray = GetFreqDictionary(matrix);
PrintArray(freqArray);