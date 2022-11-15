// Задача 1: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArray(int len)
{
    int[] result = new int[len];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(1, 10);
    }
    return result;
}

void PrintArray(int[] someArray)
{
    foreach (int item in someArray)
    {
        Console.Write($" {item} ");
    }
    Console.WriteLine();
}

void SwapElements(int[] array, int i1, int i2)
{
    int temp = array[i1];
    array[i1] = array[i2];
    array[i2] = temp;
}

int[] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        SwapElements(array, i, array.Length -1 -i);
    }
    return array;
}

int[] arr = CreateArray(10);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
