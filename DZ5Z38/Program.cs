//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int GetLengthArr()
{
    Console.Write("Введите желаемое число элементов в массиве: ");

    bool isNum = int.TryParse(Console.ReadLine(), out int Length);
    if (!isNum || Length < 1)
    {
        Console.WriteLine("Ошибка ввода!");
        Console.WriteLine("Попробуйте ввести это значение еще раз!");
        return GetLengthArr();
    }
    return Length;
}
double GetNumbArr()
{
    bool isNum = double.TryParse(Console.ReadLine(), out double numb);
    if (!isNum)
    {
        Console.WriteLine("Ошибка ввода!");
        Console.WriteLine("Попробуйте ввести это значение еще раз!");
        return GetLengthArr();
    }
    return numb;
}
double[] GetArray(int Length)
{
    double[] Arr = new double[Length];
    for (int i = 0; i < Length; i++)
    {
        Console.Write("Введите элемент массива с индексом [" + (i) + "]: ");
        Arr[i] = GetNumbArr();
    }
    PrintArr(Arr);
    return Arr;
}
void PrintArr(double[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        if (i < Arr.Length - 1)
        {
            Console.Write(Arr[i] + ", ");
        }
        else
        {
            Console.WriteLine(Arr[i]);
        }
    }
}
double MaxNumbArr(double[] Arr)
{
    double max = Arr[0];
    for (int i = 1; i < Arr.Length; i++)
    {
        if (max < Arr[i])
        {
            max = Arr[i];
        }
    }
    return max;
}
double MinNumbArr(double[] Arr)
{
    double min = Arr[0];
    for (int i = 1; i < Arr.Length; i++)
    {
        if (min > Arr[i])
        {
            min = Arr[i];
        }
    }
    return min;
}
double[] Array = (GetArray(GetLengthArr()));
Console.WriteLine("Разница между максимальным и минимальным элементом в данном массиве равна "
+ (MaxNumbArr(Array) - MinNumbArr(Array)));