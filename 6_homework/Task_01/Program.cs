/* Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

int[] CreateArray(string userInput)
{
    int counter = 1;
    for (int i = 0; i < userInput.Length; i++)
    {
        if (userInput[i] == ' ')
        {
            counter++;
        }
    }

    int[] numbers = new int[counter];
    int index = 0;

    for (int i = 0; i < userInput.Length; i++)
    {
        string temp = "";

        while (userInput[i] != ' ')
        {
            if (i != userInput.Length - 1)
            {
                temp += userInput[i].ToString();
                i++;
            }
            else
            {
                temp += userInput[i].ToString();
                break;
            }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void PrintArray(int[] array)
{
    Console.Write("Массив из введенных значений: [" + $"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.WriteLine("]");
}

int FindOverZeroNumbers(int[] numbers)
{
    int counter = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) counter++;
    }
    return counter;
}

void Runner()
{
    Console.Write("Пожалуйста, введите несколько чисел: ");
    int[] array = CreateArray(Console.ReadLine());
    PrintArray(array);
    Console.WriteLine($"Количество чисел больше 0 = {FindOverZeroNumbers(array)}");
}

Runner();