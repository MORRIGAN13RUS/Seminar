//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Четвертый способ  через string, универсально для любого количества символов в числе, но не более 10 (для int)
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool CheckPal(int x)
{
    bool check = true;
    if (x < 0)
    {
        check = false;
        return check;
    }
    string arr=x.ToString();
            for (int i = 0; i < (arr.Length - 1) / 2; i++)
    {
        if (arr[i] != arr[arr.Length - 1 - i])
        {
            check = false;
            break;
        }
    }
    return check;
}
Console.WriteLine(CheckPal(num));