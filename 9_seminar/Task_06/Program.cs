//Задача 6: Проверка на простое число: 
//N = 13 -> "Это простое число"
//N = 12 -> “Это не простое число”

bool IsSimple(int number, int divider)
{
    if (divider == 1 || number == 1)
        return true;
    return (number % divider != 0 && IsSimple(number, divider - 1));
}

int number = 1;
int divider = number - 1;
Console.WriteLine(IsSimple(number, divider));
