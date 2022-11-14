// Задача 3: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5



int[] CreateArray(int length, int min, int max)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max+1);
    }
    return tempArray;
}

void PrintArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}
int CheckElements (int[] tempArray)
{
    int count = 0;
    for(int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] > 9 && tempArray[i]<100)
        {
            count++;
        }
    }
    return count;
}


int len = 12;
int min = 0;
int max = 300;

int[] array = CreateArray(len, min, max);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(CheckElements(array));
