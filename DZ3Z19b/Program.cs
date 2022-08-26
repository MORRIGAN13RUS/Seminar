//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//способ второй, через массив int
//Отрицательное число не является палиндромом
Console.WriteLine("Введите пятизначное число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);
if (!isNumber|| num<10000|| num>99999)
{
    Console.WriteLine("Ошибка ввода числа!");
    return;
}
bool CheckPal(int x)
{
           if (x < 10000)
    {
        return false;
    }
    int[] arr = new int[5];
    for (int i = 0; i < 5; i++)
    {
        arr[i] = x % 10;
        x = x / 10;
    }
    if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        return true;
    }
    return false;
}
Console.WriteLine(CheckPal(num));