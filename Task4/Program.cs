// Задача 8: Напишите программу, которая на вход принимает число(N), а на выходе показывает все чётные числа от 1 до N.
var n = int.Parse(Console.ReadLine());
int[] res = new int[n]  ;
int count = 0;
for (int i = 1; i < n; i++)
    {
        if (i % 2 == 0)
        {
            res[count]=i;
            count++;
        }
    }
res= res.Except(new int[] { 0}).ToArray();

for (int i = 0; i < res.Length; i++)
    {
        Console.Write(res[i] + " ");
    }

