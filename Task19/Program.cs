// Задача №19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Примеры:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите 5-значное число: ");
int number = Convert.ToInt32(Console.ReadLine());

string newNumber = Convert.ToString(number);
if(newNumber.Length != 5)
    {
        Console.WriteLine("Вы ввели неправильное число!");
    }
    else
    {
        if (newNumber[0] == newNumber[4] && newNumber[1] == newNumber[3])
                Console.WriteLine("Это полиндром");
            else Console.WriteLine("это не полиндром");
    }
        
    




