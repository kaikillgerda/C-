// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

//  Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    System.Console.Write(message);   //выводит сообщение в консоли
    return int.Parse(Console.ReadLine());   // считать строку с консоли и преобразовать в целое значение
}
int N =Prompt("Введите число больше 0:");
int count=1;  // счетчик
while (count<=N)  //условие
{
    System.Console.WriteLine(count*count); //в квадрат возводим
    count++; // увеличиваем счетчик
}
for (int i = 1; i<=N; i++)  // цикл for
{
   System.Console.WriteLine(Math.Pow(i,2));
}
