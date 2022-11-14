//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(-9, 10);
    }
    return tempArray;
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]}, ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int[] MultNumbers(int[] array)
{
    int[] res = new int[array.Length / 2 + array.Length % 2];
    res[res.Length - 1] = array[res.Length - 1];
    for (int i = 0; i < array.Length / 2; i++)
    {
        res[i] = array[i] * array[array.Length - 1 - i];
    }
    return res;
}

int[] myArray = CreateArray(7);
PrintArray(myArray);
Console.WriteLine();
int[] res = MultNumbers(myArray);
PrintArray(res);