//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
bool isNummber = int.TryParse(Console.ReadLine(), out int N);
if (!isNummber || N < 1)
{
    Console.WriteLine("Ошибка ввода числа!");
    return;
}
double[] GetArr(int num)
{
    double[] arr = new double[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = Math.Pow((i + 1), 3);
    }
    return arr;
}
void PrintArr(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i < Array.Length - 1)
        {
            Console.Write(Array[i] + ", ");
        }
        else
        {
            Console.Write(Array[i]);
        }
    }
}
double[] Pow = GetArr(N);
PrintArr(Pow);
