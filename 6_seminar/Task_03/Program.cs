// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

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

int[] GetBinary(int decNumber)
{
    int[] binaryNum = new int[10];
    int i = binaryNum.Length - 1;
    while (decNumber > 0)
    {
        binaryNum[i] = decNumber % 2;
        decNumber /= 2;
        i--;
    }
    return binaryNum;
}

int decNumber = PromptInt("Введите десятичное число");
PrintArray(GetBinary(decNumber));
