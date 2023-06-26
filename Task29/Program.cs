
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("array = ");
var n = 8;//Convert.ToInt32(Console.ReadLine());

int[] array = new int [n];
for (int i = 0;i<array.Length;i++){
    array[i] = i;
    Console.Write(array[i] + " ");
}
