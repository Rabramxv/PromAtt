// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int A(int M, int N)
{
    if (M == 0) return N+1;
    if (M > 0 && N == 0) return A(M-1,1);
    if (M>0 && N > 0) return A(M-1,A(M,N-1));
    return -1;
}

int m = ReadInt("Введите число: ");
int n = ReadInt("Введите число: ");
Console.Write(A(m,n));