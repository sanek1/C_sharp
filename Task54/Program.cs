// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

var n = 4;
var m = 3;
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
var sortArr = SortArray(array,n,m);
PrintArray(sortArr, n,m);


int[,] SortArray(int[,] arr, int n, int m){
for (int i = 0; i < n; i++) {
   for (int j = m-1; j > 0; j--) {
      for (int k = 0; k < j; k++) {
         if (arr[i, k] < arr[i, k + 1]) {
            int myTemp = arr[i, k];
            arr[i, k] = arr[i, k + 1];
            arr[i, k + 1] = myTemp;
         }
      }
   }
}
return  arr;
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