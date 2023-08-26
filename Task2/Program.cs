    // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    var n1 = int.Parse(Console.ReadLine());
    var n2 = int.Parse(Console.ReadLine());
    var n3 = int.Parse(Console.ReadLine());
    var res = Math.Max(n1, Math.Max(n2, n3));
    Console.WriteLine($"max = {res}");