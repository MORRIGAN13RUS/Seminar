//Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.

Random rnd = new Random();
int[,] Arr1 = FillRandomArray();
int[,] Arr2 = FillRandomArray();
while (Arr1.GetLength(1) != Arr2.GetLength(0))
{
    Arr2 = FillRandomArray();
}
PrintArray(Arr1);
PrintArray(Arr2);
PrintArray(MultiplicatArray(Arr1, Arr2));

int[,] FillRandomArray()
{
    int[,] Arr = new int[rnd.Next(2, 6), rnd.Next(2, 6)];
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Arr[i, j] = rnd.Next(-10, 11);
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
int[,] MultiplicatArray(int[,] Arr1, int[,] Arr2)
{
    int[,] Arr3 = new int[Arr1.GetLength(0), Arr2.GetLength(1)];

    for (int i3 = 0; i3 < Arr3.GetLength(0); i3++)
    {
        for (int j3 = 0; j3 < Arr3.GetLength(1); j3++)
        {
            int i1 = i3, i2 = 0, j1 = 0, j2 = j3;
            Arr3[i3, j3] = 0;
            while (j1 < Arr1.GetLength(1) && i2 < Arr2.GetLength(0))
            {
                Arr3[i3, j3] = Arr3[i3, j3] + Arr1[i1, j1] * Arr2[i2, j2];
                j1++;
                i2++;
            }
        }
    }
    return Arr3;
}
