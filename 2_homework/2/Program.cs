// Напишите программу, которая ВЫВОДИТ СЛУЧАЙНОЕ трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.

int number = new Random().Next(100, 1000);
Console.WriteLine(number);


// 1 решение
// int firstDig = (number / 100);
// int secondDig = (number % 100) / 10;
// int thirdDig = (number % 10);
// Console.WriteLine($"{firstDig}{thirdDig}");


// 2 решение
int newnumber = number / 100 * 10 + number % 10;
Console.WriteLine(newnumber);