//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Random rnd = new Random();
int[,] Arr = FillRandomArray();
PrintArray(Arr);
PrintArray(SortingArr(Arr));

int[,] FillRandomArray()
{
    int[,] Arr = new int[rnd.Next(2, 6), rnd.Next(2, 6)];
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Arr[i, j] = rnd.Next(-100, 101);
        }
    }
    return Arr;
}

void PrintArray(int[,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] SortingArr(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        int n = 0;
        int maxI = i;
        int maxJ = n;
        int max;
        while (n < Arr.GetLength(1)-1)
        {
            max = Arr[i, n];
            maxJ = n;
            for (int j = n + 1; j < Arr.GetLength(1); j++)
            {
                if (max < Arr[i, j])
                {
                    max = Arr[i, j];
                    maxJ = j;
                }
            }
            Arr[maxI, maxJ] = Arr[i, n];
            Arr[i, n] = max;
            n++;
        }
    }
    return Arr;
}