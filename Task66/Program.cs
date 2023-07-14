Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"result = {0}",Sum(m - 1, n));

int Sum(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Sum(m, n);
        return res;
    }
}