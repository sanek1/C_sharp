
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("n = ");
var n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(n));


int SumNumbers(int n){
    var sum = 0;
        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
    return sum;
}
