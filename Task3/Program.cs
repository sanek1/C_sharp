    // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    var number = int.Parse(Console.ReadLine());
    var res = number % 2 == 0 ? "Yes" : "No";
    Console.WriteLine(res);