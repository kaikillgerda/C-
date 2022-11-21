int PromptInt(string strMessage)
{
    Console.Write(strMessage);
    int temp;
    if (int.TryParse(Console.ReadLine(), out temp))
    {
        return temp;
    }

    throw new Exception("Это не число!!!");
}

int Prompt(string message)
{
    while (true)
    try
    {
        return PromptInt(message);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Вы чтото неправильно ввели. Ошибка: {e.Message}");
    }
}
