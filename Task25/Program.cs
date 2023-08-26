//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
double pow = Math.Pow(a,b);
Console.WriteLine($"res = {pow}");
