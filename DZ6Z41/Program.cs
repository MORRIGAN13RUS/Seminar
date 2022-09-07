//Задача 41: Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

List<int> array = new List<int>();
int i = 0;
Console.WriteLine("Необходимо ввести элементы массива. Для окончания создания массива введите любой символ, кроме числа");
PrintArr(CreatArr(array, i));
Console.WriteLine();
Console.WriteLine("Количество элементов в данном массиве больше нуля равно: " + CountPozitivNumber(array));

List<int> CreatArr(List<int> arr, int i)
{
    Console.WriteLine("Введите число,которое будет элементом нового массива под индексом [" + i + "]");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        arr.Add(num);
        i++;
        return CreatArr(arr, i);
    }
    return arr;
}
void PrintArr(List<int> arr)
{
    foreach (int i in arr)
    {
        Console.Write(i + "  ");
    }
}

int CountPozitivNumber(List<int> arr)
{
    int count = 0;
    foreach (int i in arr)
    {
        if (i > 0)
        {
            count++;
        };
    }
    return count;
}