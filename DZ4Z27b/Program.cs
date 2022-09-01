//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
// Метод марихуанного курильщика или "-48"

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
{
    int summ=0;
    char [] array = number.ToString().ToCharArray();   
    for (int i = 0; i < array.Length; i++)
    {
       summ=summ+(int)array[i]-48; //перевод из юникода. 0=48,1=49 и т.д.
    }
     return summ;
}

Console.Write(GetSumm(GetTrueNumber()));
