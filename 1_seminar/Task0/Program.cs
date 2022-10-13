//Написать программу, которая на вход получает число и выдает его куб

System.Console.Write("Введите число "); //подсказка на экран
string inputString = Console.ReadLine(); //получаем введенную строку с консоли в переменную
int value = Convert.ToInt32(inputString); //преобразуем к целому типу

int cube = value * value * value; //вычисляем куб
System.Console.WriteLine(cube); //результат в консоль
