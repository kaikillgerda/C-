// Написать последовательность 1,...n
int Prompt(string msg)
{
    Console.WriteLine(msg);
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}
void Seq (int n)
{
    if (n <=0)
    {
        return;
    }
    Seq(n-1);
    Console.Write($" {n} ");
}
Seq(5);
