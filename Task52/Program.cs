// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

var n = 2;
var m = 3;
int[,] array = new int [n,m];
for(int i=0;i<n;i++)
{
    for(int j=0;j<m;j++)
    {
        array[i, j]= new Random().Next(0,9);
        Console.WriteLine("[{0}, {1}] = {2}", i, j, array[i,j]);
    }
}
FinfValue(array,n,m);

void FinfValue(int[,] arr, int n, int m){
    string res1 = "";
    for(int j=0;j<m;j++)
    {
        float sum =0;
        for(int i=0;i<n;i++)
        {
            sum+=arr[i,j];
        }
        float res = sum / n;
        Console.WriteLine($"{res}");
    } 
}