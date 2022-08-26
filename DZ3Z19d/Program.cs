//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Четвертый способ  через string, универсально для любого количества символов в числе, но не более 10 (для int)
//В данном случае предполагаем, что палиндромом является любое положительное число начиная от двух символов и более.
Console.WriteLine("Введите целое число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);
if (!isNumber)
{
    Console.WriteLine("Ошибка ввода числа!");
    return;
}
bool CheckPal(int x)
{
    string arr = x.ToString();
    if (x < 10 || x > 9 && x < 100 && arr[0] != arr[1])
    {
        return false;
    }
    for (int i = 0; i < (arr.Length - 1) / 2; i++)
    {
        if (arr[i] != arr[arr.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine(CheckPal(num));