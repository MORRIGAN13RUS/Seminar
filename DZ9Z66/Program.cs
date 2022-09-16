//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Random rnd = new Random();
int M=rnd.Next(1,21);
int N=rnd.Next(M+1,M+20);
int GetSumNumb (int M,int N){
if(M<=N) return M+GetSumNumb(M+1,N);
else return 0;
}
Console.WriteLine($"Сумма натуральных элементов от {M}  до {N} равна " + GetSumNumb(M,N));