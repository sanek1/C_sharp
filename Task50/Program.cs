// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

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
var value = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FinfValue(array,value,n,m));

string FinfValue(float[,] arr, int value, int n, int m){
    for(int i=0;i<n;i++)
    {
        for(int j=0;j<m;j++)
        {
            if(arr[i,j] == value) return $"i= {i}, j = {j}";
        }
    }
    return "такого числа в массиве нет";
}