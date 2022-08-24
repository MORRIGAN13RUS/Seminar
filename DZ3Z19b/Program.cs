//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//способ второй, через массив int
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool CheckPal(int x)
{
    bool check = false;
    if (x < 0)
    {
        return check;
    }
    int[] arr = new int[5];
    for (int i = 0; i < 5; i++)
    {
        arr[i] = x % 10;
        x = x / 10;
    }

    if (arr[0] == arr[4] && arr[1] == arr[3])
    {
        check = true;
    }
    return check;
}
Console.WriteLine(CheckPal(num));