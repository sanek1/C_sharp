//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
string FindNumber(int number){
    var res = "Нет";
    switch(number){
        case 6: res = "Да"; break;
        case 7:  res = "Да";break;
        default: res = "Нет";break;
    }
    return res;
}

var number = int.Parse(Console.ReadLine());
var res = FindNumber(number);
Console.WriteLine(FindNumber(number));