//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int? FindNumber(int number, int count){
    var stringNumber = number.ToString();
    if(count > stringNumber.Length)  return null;
    return int.Parse(stringNumber[count-1].ToString());
}

var number = int.Parse(Console.ReadLine());
var res = FindNumber(number, 3);
Console.WriteLine(res == null ? "третьей цифры нет":$"{res}");