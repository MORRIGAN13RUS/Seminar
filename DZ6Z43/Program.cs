//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Для определения пересечение двух прямых, заданных уравнениями:" +
"y = k1 * x + b1, y = k2 * x + b2 введите значения переменных");
Console.Write("Введите значение k1= ");
double k1= (GetTrueNumber());
Console.Write("Введите значение b1= ");
double b1= (GetTrueNumber());
Console.Write("Введите значение k2= ");
double k2= (GetTrueNumber());
Console.Write("Введите значение b2= ");
double b2=(GetTrueNumber());

double GetTrueNumber()
{
    bool isNum = double.TryParse(Console.ReadLine(), out double num);
    if (!isNum)
    {
        Console.WriteLine("Ошибка ввода!");
        Console.WriteLine("Попробуйте ввести число еще раз:");
        return GetTrueNumber();
    }
    return num;
}
double[] GetArrCoordinates(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    double[] arr = { x, y };
    return arr;
}
if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Данные прямые не имеют пересечений, так как они являются параллельными.");
    return;
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Данные прямые не имеют пересечений, так как они совпадают!");
    return;
}
else
{
    double[] arr = GetArrCoordinates(k1, b1, k2, b2);
    Console.WriteLine("Прямые с введеными коэффициентами пересекаются в точке (" + arr[0] + ", " + arr[1] + ")");
}

