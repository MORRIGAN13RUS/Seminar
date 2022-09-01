//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
// Через перевод в int массив

int GetTrueNumber()
{
    Console.Write("Введите желаемое число: ");

    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (!isNum)
    {
        Console.WriteLine("Ошибка ввода!");
        Console.WriteLine("Попробуйте ввести это значение еще раз!");
        return GetTrueNumber();
    }
    if (num < 0)
    {
        num = num * -1;
    }
    return num;
}
int GetSumm(int number)
{int summ=0;
    int [] array = number.ToString().Select(e=>int.Parse(e.ToString())).ToArray();   
    for (int i = 0; i < array.Length; i++)
    {
        summ=summ+array[i];
    }
     return summ;
}

Console.Write(GetSumm(GetTrueNumber()));