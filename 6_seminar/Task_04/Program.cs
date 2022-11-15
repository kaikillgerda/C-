// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

int[] CreateArray(int temp)
{
    if(temp <2)
    {
        temp = 2;
    }
    int[] tempArray = new int[temp];
    tempArray[0] = 0;
    tempArray[1] = 1;
    for (int i = 2; i < temp; i++)
    {
        tempArray[i] = tempArray[i-1] + tempArray[i-2];
    }
    return tempArray;
}

int digit = PromptInt("Введите число: ");
int[] Fibonacci = CreateArray(digit);
PrintArray(Fibonacci);
