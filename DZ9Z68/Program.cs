//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

Random rnd = new Random();
int M = rnd.Next(0, 5);
int N = rnd.Next(0, 6);
int GetAkkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (M > 0 && N == 0) return GetAkkerman(M - 1, 1);
    else if (M > 0 && N > 0) return GetAkkerman(M - 1, GetAkkerman(M, N - 1));
    return GetAkkerman(M, N);
}
Console.WriteLine($"Результат вычесления функции Аккермана  А({M}, {N}) равен: " + GetAkkerman(M, N));