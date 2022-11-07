// Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом 
// [1, 3, 5, 6, 6, 4] -> 5

int[] CreateArray(int Length = 8)
{
    int[] tempArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        tempArray[i] = new Random().Next(-9, 0);
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
int findSecondMax(int[] intArray)
{
    int tempMax = intArray[0];
    int tempSecMax = 0;
    for (int i = 1; i < intArray.Length; i++)
    {
        if (tempMax < intArray[i])
        {
            tempSecMax = tempMax;
            tempMax = intArray[i];
        }
        else
        {
            if (tempSecMax <= intArray[i] && intArray[i] != tempMax)
            {
                tempSecMax = intArray[i];
            }
        }
    }
    return tempSecMax;
}

System.Console.Write("Второе максимальное число в случайном массиве: ");
int[] maxArray = CreateArray();
printArray(maxArray);
System.Console.Write($"-> {findSecondMax(maxArray)}");
