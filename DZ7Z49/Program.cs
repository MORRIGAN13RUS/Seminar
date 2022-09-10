//Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//7 -> 0 , 2
//5 -> 1 , 0
//18 -> нет такого элемента

Random rnd = new Random();
int[,] Array = FillRandomArray();
PrintArray(Array);
int numb = GetNumbRandom();
int[] Arr = SearchNumb(Array, numb);
PrintCheck(Arr, numb);

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
}
int GetNumbRandom()
{
    Console.Write("Введите желаемое число от -10 до 10 для поиска его в массиве: ");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (!isNum || num < -10 || num > 10)
    {
        Console.WriteLine("Ошибка ввода!");
        Console.WriteLine("Попробуйте ввести искомое число еще раз!");
        return GetNumbRandom();
    }
    return num;
}
int[] SearchNumb(int[,] Array, int num)
{
    int[] Arr = { -1, -1 };
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] == num)
            {
                Arr[0] = i;
                Arr[1] = j;
                return Arr;
            }
        }
    }
    return Arr;
}

void PrintCheck(int[] Arr, int numb)
{
    if (Arr[0] == -1)
    {
        Console.WriteLine("В данном двумерном массиве такого элемента нет");
    }
    else
    {
        Console.WriteLine("Индексы расположения числа " + numb + " в данном двумерном массиве: [" + Arr[0] + ", " + Arr[1] + "]");
    }
}