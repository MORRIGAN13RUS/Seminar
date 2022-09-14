//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Random rnd = new Random();
int[,,] Arr = FillRandomArray();
PrintArray(Arr);


int[,,] FillRandomArray()
{
    int kLength = rnd.Next(2, 6);
    int iLength = rnd.Next(2, 6);
    int jLength = rnd.Next(2, 6);
    while (iLength * jLength * kLength > 90)
    {
        kLength = rnd.Next(2, 6);
        iLength = rnd.Next(2, 6);
        jLength = rnd.Next(2, 6);
    }
    Console.WriteLine("Параметры  массива: " + kLength + ", " + iLength + ", " + jLength);
    int[,,] Arr = new int[kLength, iLength, jLength];
    for (int k = 0; k < Arr.GetLength(0); k++)
    {
        for (int i = 0; i < Arr.GetLength(1); i++)
        {
            for (int j = 0; j < Arr.GetLength(2); j++)
            {
                Arr[k, i, j] = rnd.Next(10, 100);
                for (int x = k + 1; x < Arr.GetLength(0); x++)
                {
                    for (int y = i + 1; y < Arr.GetLength(1); y++)
                    {
                        for (int z = j + 1; z < Arr.GetLength(2); z++)
                        {
                            while (Arr[k, i, j] == Arr[x, y, z])
                            {
                                Arr[k, i, j] = rnd.Next(10, 100);
                            }
                        }
                    }
                }
            }
        }
    }
    return Arr;
}

void PrintArray(int[,,] Array)
{
    for (int k = 0; k < Array.GetLength(0); k++)
    {
        for (int i = 0; i < Array.GetLength(1); i++)
        {
            for (int j = 0; j < Array.GetLength(2); j++)
            {
                Console.Write(Array[k, i, j] + "(" + k + "," + i + ", " + j + ")" + "  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}