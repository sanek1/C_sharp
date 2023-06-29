
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

var n = 6;
var array  = GetRandomArray(n);;
GetResult(array);

float[] GetRandomArray(int n){
    float[] array = new float [n];
    for (int i = 0;i<array.Length;i++){
        array[i] = new Random().Next(-100,999);
    }
    return array;
}

void GetResult(float[] array){
    float min  =array[0];
    float max  =array[0];
    for (int i = 0;i<array.Length;i++){
        Console.Write(array[i] + " ");
        if (array[i] < min) min= array[i];
        if (array[i] > max) max= array[i];
    }
    Console.Write($" => {max} - {min} = {max-min} ");
}