// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
int Prompt(string text)
{
    System.Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int DivBy (int A, int B) // вычисляем остаток от деления B на A (2 / 4 = 0 целых и 2 в остатке)
{
    return (B % A);
}

int A = Prompt("Введите первое число: ");
int B = Prompt("Введите второе число: ");

if (DivBy(A, B) == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine(DivBy(A, B));
}
                                                                                     