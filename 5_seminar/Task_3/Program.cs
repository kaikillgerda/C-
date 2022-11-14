//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да
int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}
int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(-9, 10);
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
    System.Console.WriteLine();
}
bool IsHasNumber(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }
    return false;
}
int[]array = CreateArray (10);
PrintArray(array);
int number = PromptInt($" Введите число, которое ищем  ");
if (IsHasNumber(number, array))
{
    System.Console.WriteLine($"yes");
}
else
{
    System.Console.WriteLine($"no");
}
