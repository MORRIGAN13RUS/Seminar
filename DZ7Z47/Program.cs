//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Random rnd = new Random();
int m = rnd.Next(2, 10);
int n = rnd.Next(2, 10);
PrintArray(FillRandomArray(m, n));

double[,] FillRandomArray(int m, int n)
{
    double[,] Arr = new double[m, n];
    double x;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            x = rnd.Next(-999, 1000);
            Arr[i, j] = x / 10;
        }
    }
    return Arr;
}
void PrintArray(double[,] Array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(Array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}