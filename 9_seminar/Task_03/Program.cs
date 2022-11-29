// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Использовать рекурсию.
// 453 -> 12
// 45 -> 9


int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = Convert.ToInt32(System.Console.ReadLine());
    return temp;
}

int sumNumbers(int digit)
{
    if(digit <= 0)
    {
        return 0;
    }
    return (digit%10) + sumNumbers(digit/10); 
}

int digit = Prompt("Введите число: ");

System.Console.WriteLine(sumNumbers(digit));
