// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели ");
int n = int.Parse(Console.ReadLine());

string[] days = new string[7] { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };
if (n > 0 && n < 8)
    Console.WriteLine(days[n - 1]);