// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// Примеры:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] pointA = new double [3];
double[] pointB = new double [3];
double distance = 0;

Console.WriteLine("введите координаты первой точки - X, Y, Z");
for (int i = 0; i < pointA.Length; i ++)
    pointA[i] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите координаты второй точки - X, Y, Z");
for (int i = 0; i < pointB.Length; i ++)
    pointB[i] = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(pointA[0] - pointB[0], 2) + Math.Pow(pointA[1] - pointB[1], 2) + Math.Pow(pointA[2] - pointB[2], 2));
Console.WriteLine($"Растояние между точками равно {Math.Round(distance, 2)}");