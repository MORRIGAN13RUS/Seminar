//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
double[] A = new double [3];
double[] B = new double [3];
GetArr(A);
GetArr(B);
double [] GetArr(double [] Arr){
     Console.WriteLine("Введите коорднаты точки: ");
    for(int i=0; i<3; i++ ){       
        bool isNumber=int.TryParse(Console.ReadLine(),out int x);
        if (isNumber){
Arr[i]=x;
        }
        else {
            Console.WriteLine("Координаты введены неверно.Повторите ввод сначала!");
        GetArr(Arr);
        }

    }
    return Arr;
}
double GetCad(double[] arr1, double[] arr2)
{
    double cad = Math.Sqrt(
        Math.Pow(arr2[0] - arr1[0], 2)
        + Math.Pow(arr2[1] - arr1[1], 2)
        + Math.Pow(arr2[2] - arr1[2], 2));
    return cad;
}
Console.WriteLine("Длинна отрезка:" + GetCad(A, B));