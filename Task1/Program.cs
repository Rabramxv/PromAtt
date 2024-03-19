int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int n, int m)
{
    if(n>m) return;
    System.Console.Write(n + " "); 
    PrintNumbers(n+1,m);
}

int N = ReadInt("Введите число: ");
int M = ReadInt("Введите число: ");
PrintNumbers(N,M);