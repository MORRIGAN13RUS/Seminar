//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
int GetLengthArr()
{
    Console.Write("Введите желаемое число элементов в массиве: ");

    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (!isNum || num < 1)
    {
        Console.WriteLine("Ошибка ввода!");
        Console.WriteLine("Попробуйте ввести это значение еще раз!");
        return GetLengthArr();
    }
    return num;
}
int[] GetArray(int Length)
{
    int[] Arr = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        Console.Write($"Введите число, которое будет в данном массиве под индексом {i}: ");
        Arr[i] = GetValNum();
    }
    return Arr;
}
int GetValNum()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (!isNum)
    {
        Console.WriteLine("Ошибка ввода!");
        Console.WriteLine("Попробуйте ввести этого значения еще раз!");
        return GetValNum();
    }
    return num;
}
void PrintArr(int[] Arr)
{
    Console.Write("[");
    for (int i = 0; i < Arr.Length - 1; i++)
    {
        Console.Write(Arr[i] + ", ");
    }
    Console.Write(Arr[Arr.Length - 1] + "]");
}
PrintArr(GetArray(GetLengthArr()));

