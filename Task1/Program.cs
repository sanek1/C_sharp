 //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
var num1 = int.Parse(Console.ReadLine());
var num2 = int.Parse(Console.ReadLine());
var res = num1>num2 ?num1 :num2;
Console.WriteLine($"max = {res}");