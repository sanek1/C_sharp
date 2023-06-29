
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

var n = 8;
int count  =0;
int[] array = new int [n];

for (int i = 0;i<array.Length;i++){
    array[i] = new Random().Next(100,999);
    if (array[i] % 2 == 0){
        count++;
    }
}

for (int i = 0;i<array.Length;i++){
    Console.Write(array[i] + " ");
}
Console.Write(" => ");
Console.Write(count);