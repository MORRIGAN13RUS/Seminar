//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

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
    if(num<0)
    { 
        num=num * -1;
    }
    return num;
}
int GetSumm(int number)
{
    int summ=0;
    while(number>0)
    {
        summ=summ+number%10;
        number=number/10;
    }
return summ;
}

 Console.Write(GetSumm( GetTrueNumber()));
