﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число, и мы узнаем чётное оно или нет: ");
int number = int.Parse(Console.ReadLine());
if(number % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else if (number % 2 == 1)
{
    Console.WriteLine("Число нечётное");
}
else if (number % 2 == -1)
{
    Console.WriteLine("Число нечётное");
}