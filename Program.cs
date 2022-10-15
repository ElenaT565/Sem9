//Задача 64

/*Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

string Rec(int MinValue, int N)
{
    if(MinValue == N)
    {
        return N.ToString();
    }
    return (MinValue + " " + Rec(MinValue - 1, N));
}
Console.WriteLine(Rec(N, 1));*/

// Задача 66

/*Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($" Сумма равна {sum(m,n)}");

int sum(int m, int n)
{
    int summa = 0;   
    if (m == n)
    {
        return n;
    }
    else{
        summa = m + sum (m+1, n);   
        return summa; 
    }
 }*/

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());

   int Accer(int n, int m)
    {
        if (n < 0 || m < 0);
        if (n == 0) 
        {
            return m + 1;
            }
        if (m == 0) {
        return n + 1;
        }
        return Accer(n - 1, Accer(n, m - 1));
    }
   
        Console.WriteLine(Accer(n,m));
      
