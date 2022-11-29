// Задача 5: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

bool DevideByTwo(int n)
{
    // if (n == 2 || n == 1) return true;
    // else if (n != 2) return false;
    // else return DevideByTwo (n/2);
    if (n == 1) return true;
    if (n == 2) return true;
    return (n % 2 == 0 && DevideByTwo(n / 2));
}

int n = 60;
if (DevideByTwo(n)) Console.WriteLine("Является степень двойки");
else Console.WriteLine("Не является степенью двойки");
