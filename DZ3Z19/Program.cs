//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//способ первый, без массива
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool CheckPal(int x)
{
    bool check = false;
    if (x < 0)
    {
        return check;
    }
    int a5 = x % 10;
    x = x / 10;
    int a4 = x % 10;
    x = x / 10;
    int a3 = x % 10;
    x = x / 10;
    int a2 = x % 10;
    int a1 = x / 10;
    if (a5 == a1 && a4 == a2)
    {
        check = true;
    }
    return check;
}
Console.WriteLine(CheckPal(num));

