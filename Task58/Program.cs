// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

var m = 2;
var n = 2;
var p = 2;

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];


MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nИтоговая матрица:");
PrintArray(resultMatrix);


void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(9);
    }
  }
}

void PrintArray (int[,] arr){
    for(int i=0;i<arr.GetLength(0); i++){
        for(int j=0;j<arr.GetLength(1);j++)
            {
                Console.Write(arr[i,j]+ " ");
            }
        Console.WriteLine();
    }
}