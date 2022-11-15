// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int Prompt(string message)
{
    Console.Write(message + " -> ");
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
    }
    return tempArray;
}

void PrintArray(int[] someArray)
{
    Console.Write($"{someArray[0]}");
    for (int i = 1; i < someArray.Length; i++)
    {
        Console.Write($", {someArray[i]}");
    }
}

void FindEven(int[] tempArray)
{
    int evens = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] % 2 == 0) evens++;
    }
    Console.WriteLine($" -> {evens}");
}

void Runner()
{
    int arrLeng = Prompt("Пожалуйста, введите количество элементов массива");
    int arrMin = Prompt("Пожалуйста, введите минимальное значение элементов массива");
    int arrMax = Prompt("Пожалуйста, введите максимальное значение элементов массива");
    int[] array = CreateArray(arrLeng, arrMin, arrMax);
    PrintArray(array);
    FindEven(array);
}

Runner();