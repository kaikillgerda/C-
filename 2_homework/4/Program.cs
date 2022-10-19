// Напишите программу, которая ПРИНИМАЕТ на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 1 || number > 7)
    {
        Console.WriteLine("В неделе 7 (семь) дней: от 1 (понедельник) до 7 (воскресенье). Пожалуйста, попробуйте еще раз.");
        return false;
    }
    return true;
}

int number = Prompt("Пожалуйста, введите цифру, обозначающую день недели: ");
if (ValidateNumber(number))
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}