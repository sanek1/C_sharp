//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int FindNumber(int number, int count){
    var stringNumber = number.ToString();
    return int.Parse(stringNumber[count-1].ToString());
}

var number = int.Parse(Console.ReadLine());
var res = FindNumber(number, 2);
Console.WriteLine($"Value = {res}");