﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// Примеры:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите целое положительное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for(int i = 1; i <= number; i ++)
    {
        Console.Write(Math.Pow(i, 3) + "\t");
    }
}
else Console.WriteLine("Вы ввели неправильное число");