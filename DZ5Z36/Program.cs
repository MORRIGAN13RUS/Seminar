//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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
int GetNumbRandom()
{
    Console.Write("Введите желаемое число, определяющего интервал чисел в массиве: ");

    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (!isNum)
    {
        Console.WriteLine("Ошибка ввода!");
        Console.WriteLine("Попробуйте ввести это значение еще раз!");
        return GetLengthArr();
    }
    return num;
}
Random Ran = new Random(); //создаем обьект Рандом, выделяя память под него
int[] GetArray(int Length, int num1, int num2)
{
    int[] Arr = new int[Length];
    if (num1 < num2)
    {
        for (int i = 0; i < Length; i++)
        {
            Arr[i] = Ran.Next(num1, num2 + 1);
        }
    }
    else
    {
        for (int i = 0; i < Length; i++)
        {
            Arr[i] = Ran.Next(num2, num1 + 1);
        }
    }
    PrintArr(Arr);
    return Arr;
}
void PrintArr(int[] Arr)
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
int SummIndexOddNumb(int[] Arr)
{
    int Summ = 0;
    for (int i = 0; i < Arr.Length; i = i + 2)
    {
        Summ = Summ + Arr[i];
    }
    return Summ;
}
Console.WriteLine("Сумма чисел, стоящих на нечетных позициях в данном массиве равна "
+ SummIndexOddNumb(GetArray(GetLengthArr(), GetNumbRandom(), GetNumbRandom())));