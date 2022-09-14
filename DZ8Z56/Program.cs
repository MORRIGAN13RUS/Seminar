//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Random rnd = new Random();
int[,] Arr = FillRandomArray();
PrintArray(Arr);
Console.WriteLine("В данном массиве номер строки с наименьшей суммой элементов: " + (NumbStringSumMinArray(Arr) + 1));

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

int NumbStringSumMinArray(int[,] Array)
{
    int indexSumMin = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int summ = 0;
        int SumMin = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            summ = summ + Array[i, j];
        }
        if (SumMin > summ)
        {
            SumMin = summ;
            indexSumMin = i;
        }
    }
    return indexSumMin;
}
