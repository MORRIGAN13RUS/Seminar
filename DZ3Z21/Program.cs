//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
double[] A = { 3, 6, 8 };
double[] B = { 2, 1, -7 };
double GetCad(double[] arr1, double[] arr2)
{
    double cad = Math.Sqrt(
        Math.Pow(arr2[0] - arr1[0], 2)
        + Math.Pow(arr2[1] - arr1[1], 2)
        + Math.Pow(arr2[2] - arr1[2], 2));
    return cad;
}
Console.WriteLine("Длинна отрезка:" + GetCad(A, B));