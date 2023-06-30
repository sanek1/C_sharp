// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

var n = 3;
var m = 4;
float[,] array = new float [n,m];
for(int i=0;i<n;i++)
{
    for(int j=0;j<m;j++)
    {
        array[i, j]= new Random().Next(-100,999);
        Console.WriteLine("[{0}, {1}] = {2}", i, j, array[i,j]);
    }
}