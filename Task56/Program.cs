// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

var n = 4;
var m = 4;
int[,] array = new int [n,m];
for(int i=0;i<n;i++)
{
    for(int j=0;j<m;j++)
    {
        array[i, j]= new Random().Next(0,9);
    }
}
PrintArray(array, n,m);
Console.WriteLine();
var res = FindMinSummLine(array,n,m);
Console.Write($"{res +1} - строка самая минимальная");


int FindMinSummLine(int[,] arr, int n, int m){
var res = 999;
var index = 0;
var sum = 0;
for (int i = 0; i < n; i++) {
   for (int j = 0; j < m; j++) {
      sum+=arr[i, j];
   }
   if(sum < res){
    res = sum;
    index=i;
   }
   sum = 0;
}
return  index;
}


void PrintArray (int[,] arr, int n, int m){
    for(int i=0;i<n; i++){
        for(int j=0;j<m;j++)
            {
                Console.Write(arr[i,j]+ " ");
            }
        Console.WriteLine();
    }
}