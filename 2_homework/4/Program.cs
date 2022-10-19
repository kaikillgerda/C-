// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
bool ValidateNumber(int number)
{
    if (number > 0 || number < 8)
    {
        Console.WriteLine("В неделе 7 (семь) дней: от 1 (понедельник) до 7 (воскресенье)");
        return false;
    }
    return true;
}
int number = Prompt("Введите цифру от 1 (понедельник) до 7 (воскресенье): ");
if (ValidateNumber(number))
{
    if (number == 6 || number == 7) 
    {
    Console.WriteLine("");
    }
    
}