int Method()
{
    return DateTime.Now.DayOfYear;
}
int time = Method();
Console.WriteLine(time);