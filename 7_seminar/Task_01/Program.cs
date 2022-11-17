// Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void PrintArray (int[,] arrNums)
{
    for (int i=0; i<arrNums.GetLength(0); i++)
    {
        System.Console.Write($"{arrNums[i, 0]}");
        for (int j=1; j<arrNums.GetLength(1); j++)
        {
            System.Console.Write($" {arrNums[i, j]}");
        }
        System.Console.WriteLine("");    
    }
}
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i=0; i<m; i++)
    {
        for (int j=0; j<n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;   
}

void Execute()
{
    int intM = PromptInt("Введите размерность M (строки): ");
    int intN = PromptInt("Введите размерность N (столбцы): ");
    int[,] tempArray = FillArray(intM, intN);
    PrintArray (tempArray);
}

Execute();
