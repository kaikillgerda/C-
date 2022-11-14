double Average(int[] arr)
{
    double total = 0;
    foreach (int item in arr)
    {
        total += item;
    }

    return total / arr.Length;
}

double MiddleSquare(int[] arr)
{
    double total = 0;
    foreach (var item in arr)
    {
        total += Math.Pow(item, 2);
    }
    return Math.Sqrt(total / arr.Length);
}
