
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

var n = 6;
int count  =0;
int[] array = new int [n];

for (int i = 0;i<array.Length;i++){
    array[i] = new Random().Next(-100,999);
    if (i % 2 != 0){
        count += array[i];
    }
}

for (int i = 0;i<array.Length;i++){
    Console.Write(array[i] + " ");
}
Console.Write(" => ");
Console.Write(count);