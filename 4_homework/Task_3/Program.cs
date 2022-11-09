// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах).  Реализовать через функции. 
// (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

int Prompt(string message)
{
    Console.Write(message + " > ");
    return int.Parse(Console.ReadLine());
}

int length = Prompt("Введите количество элементов массива");
int min = Prompt("Введите минимальный порог случайных значений");
int max = Prompt("Введите максимальный порог случайных значений");

bool ValidateNumber(int min, int max, int length)
{
    if (max <= min || length == 0)
    {
        Console.WriteLine("Максимальное значение должно быть больше минимального, а количество элементов в массиве не может быть равно 0, попробуйте еще раз");
        return false;
    }
    return true;
}

int[] Array(int length)
{
    int[] tempArr = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArr[i] = new Random().Next(min, max);
    }
    return tempArr;
}

void printArray(int[] intArray)
{
    Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        Console.Write($", {intArray[i]}");
    }
}

if (ValidateNumber(min, max, length))
{
    Console.Write($"Случайный массив длиной {length} значения, включающий значения от {min} до {max}: ");
    printArray(Array(length));
}