// Напишите программу, которая выводит второе наибольшее число в массиве

int[] GetRandomArray(int length)    //возвращает массив заданной длины, заполненный случайными числами.
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 9);
    }
    return arr;
}

void printArray(int[] arr)  //Выводит содержимое массива на экран
{
    System.Console.Write($"{arr[0]}");
    for (int i = 1; i < arr.Length; i++)
    {
        System.Console.Write($", {arr[i]}");
    }
}

int findSecondMax(int[] arr)
{
    int firstMax = arr[1];
    int secondMax = arr[0];
    if (secondMax > firstMax)
    {
        int tmp = firstMax;
        firstMax = secondMax;
        secondMax = tmp;
    }
    //Console.Write($"{firstMax},");
    //Console.Write($"{secondMax} ");
    for (int i = 2; i < arr.Length; i++)
    {
        if (firstMax < arr[i])
        {
            secondMax = firstMax;
            firstMax = arr[i];
        }
        else
        {
            if (secondMax < arr[i] && arr[i]<firstMax)
            {
                secondMax = arr[i];
            }
        }
       //Console.Write($"{firstMax},");
       //Console.Write($"{secondMax} ");
    }
    return secondMax;
}

//System.Console.Write("Случайный массив длиной 8 со значениями 0 и 1: ");
Console.Clear();
int[] maxArray = GetRandomArray(10);
printArray(maxArray);
Console.WriteLine();
System.Console.Write($"-> {findSecondMax(maxArray)}");