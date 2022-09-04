//Задача 34: 
//Задайте массив, заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
Random Ran = new Random(); //создаем обьект Рандом, выделяя память под него
int[] GetArray(int Length)
{
    int[] Arr = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        Arr[i] = Ran.Next(100, 1000);
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
int SummEvenNumb(int[] Arr)
{
    int Summ = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] % 2 == 0)
        {
            Summ++;
        }
    }
    return Summ;
}
Console.WriteLine(SummEvenNumb(GetArray(GetLengthArr())) + " четных числа в данном массиве");