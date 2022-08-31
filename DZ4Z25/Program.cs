//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int GetTrueNumberA()
{
    Console.Write("Введите  число, которое желаете возвести в степень: ");

    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (!isNum)
    {
        Console.WriteLine("Ошибка ввода!");
        Console.WriteLine("Напрягите свой мозг и попробуйте ввести это число еще раз!");
        return GetTrueNumberA();
    }
    return num;
}

int GetTruePowerB()
{
    Console.Write("Введите  степень (натуральное число), в которую будет возведено предыдущее введенное число: ");

    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (!isNum|| num<1)
    {
        Console.WriteLine("Ошибка ввода!");
        Console.WriteLine("Напрягите хотябы одну извилину и попытайтесь ввести степень еще раз!");
        return GetTruePowerB();
    }
    return num;
}
void PrintNumberToPower(int A, int B){
    int res=1;
    for (int i = 1; i <=B; i++)
    {
       res=res*A;
    }
    Console.WriteLine($"Результат возведения {A} в натуральную степень {B} равен {res}");
}
PrintNumberToPower(GetTrueNumberA(),GetTruePowerB());