//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random rnd = new Random();
int[,] KarinaRandomArray = FillRandomArray();
PrintArray(KarinaRandomArray);
PrintArrayArithmeticMean(GetArrayArithmeticMean(KarinaRandomArray));

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
}

double[] GetArrayArithmeticMean(int[,] Arr)
{
    double[] ArrAM = new double[Arr.GetLength(1)];
    for (int n = 0; n < Arr.GetLength(1); n++)
    {
        int summ = 0;
        for (int i = 0; i < Arr.GetLength(0); i++)
        {
            for (int j = 0; j < Arr.GetLength(1); j++)
            {
                if (j == n)
                {
                    summ += Arr[i, j];
                }
            }
        }
        double x=summ;
        ArrAM[n] = x / Arr.GetLength(0);
    }
    return ArrAM;
}

void PrintArrayArithmeticMean(double[] Array)
{
    Console.WriteLine("Среднее арифмитическое по столбцам: ");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + "  ");
    }
}
