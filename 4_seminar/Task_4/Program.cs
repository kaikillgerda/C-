// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] CreateArray(int Length = 8)
{
    int[] tempArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        tempArray[i] = new Random().Next(0, 2);
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

System.Console.Write("Случайный массив длиной 8 со значениями 0 и 1: ");
printArray(CreateArray());
