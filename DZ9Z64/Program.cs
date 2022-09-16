//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

Random rnd = new Random();
int M=rnd.Next(1,21);
int N=rnd.Next(M+1,M+20);
string GetListNumb (int M,int N){
if(M<=N) return $"{M}  "+GetListNumb(M+1,N);
else return string.Empty;
}
Console.WriteLine(GetListNumb(M,N));