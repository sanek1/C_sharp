//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
var value = Console.ReadLine();
Console.WriteLine(value.SequenceEqual(value.Reverse()) ? "ДА" : "НЕТ");