// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int num = Prompt("Введите число: ");
int count = 1;
while (count <= num)
{
    Console.WriteLine(count * count * count);
    count++;
}