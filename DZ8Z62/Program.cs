//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int n = 1;
Random rnd = new Random();
int[,] Arr = new int[rnd.Next(2, 10), rnd.Next(2, 10)];
PrintArray(FillArr2(FillArr1(Arr), 1, 1));
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Arr[i, j] < 10) { Console.Write(0); }
            Console.Write(Array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] FillArr2(int[,] Arr, int i, int j)
{
    if (Arr[i, j] == 0)
    {
        Arr[i, j] = n;
        n++;
        if (Arr[i - 1, j] != 0)
        {
            FillArr2(Arr, i, j + 1);
        }
        FillArr2(Arr, i + 1, j);
        FillArr2(Arr, i, j - 1);
        FillArr2(Arr, i - 1, j);
    }
    return Arr;
}
int[,] FillArr1(int[,] Arr)
{
    for (int j = 0; j < Arr.GetLength(1); j++)
    {
        Arr[0, j] = n;
        n++;
    }
    for (int i = 1; i < Arr.GetLength(0); i++)
    {
        Arr[i, Arr.GetLength(1) - 1] = n;
        n++;
    }
    for (int j = Arr.GetLength(1) - 2; j >= 0; j--)
    {
        Arr[Arr.GetLength(0) - 1, j] = n;
        n++;
    }
    for (int i = Arr.GetLength(0) - 2; i > 0; i--)
    {
        Arr[i, 0] = n;
        n++;
    }
    return Arr;
}
