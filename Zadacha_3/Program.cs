﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int rest = number % 2;
if (rest == 0)
{
    Console.WriteLine("Да, число чётное");
}
else
{
    Console.WriteLine("Число не чётное");
}
