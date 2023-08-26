
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
float x1 = 3;
float y1 = 6;
float z1 = 8;

float x2 = 2;
float y2 = 1;
float z2 = -7;

float deltaX = x1 - x2;
float deltaY = y1 - y2;
float deltaZ = z1 - z2;

float distance = (float) Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

Console.WriteLine(distance);