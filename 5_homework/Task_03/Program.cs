// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int Prompt(string message)
{
    Console.Write(message + " -> ");
    return int.Parse(Console.ReadLine());
}

double[] CreateArray(int length, int min, int max)
{
    double[] tempArray = new double[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(min, max) + new Random().NextDouble();
    }
    return tempArray;
}

void PrintArray(double[] array)
{
    Console.Write($"{array[0]:f2}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]:f2}");
    }
}

double MaxVal(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinVal(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double DifMaxMin(double[] array)
{
    double max = MaxVal(array);
    double min = MinVal(array);
    double difMinMax = max - min;
    return difMinMax;
}

void Runner()
{
    int arrLeng = Prompt("Пожалуйста, введите количество элементов массива");
    int arrMin = Prompt("Пожалуйста, введите минимальное значение элементов массива");
    int arrMax = Prompt("Пожалуйста, введите максимальное значение элементов массива");
    double[] array = CreateArray(arrLeng, arrMin, arrMax);
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"{DifMaxMin(array):f2}");
}

Runner();