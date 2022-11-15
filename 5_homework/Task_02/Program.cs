// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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

void FindOddPositionSum(int[] tempArray)
{
    int oddsSum = 0;
    for (int i = 0; i < tempArray.Length; i = i + 2)
    {
        oddsSum = oddsSum + tempArray[i];
    }
    Console.WriteLine($" -> {oddsSum}");
}

void Runner()
{
    int arrLeng = Prompt("Пожалуйста, введите количество элементов массива");
    int arrMin = Prompt("Пожалуйста, введите минимальное значение элементов массива");
    int arrMax = Prompt("Пожалуйста, введите максимальное значение элементов массива");
    int[] array = CreateArray(arrLeng, arrMin, arrMax);
    PrintArray(array);
    FindOddPositionSum(array);
}

Runner();