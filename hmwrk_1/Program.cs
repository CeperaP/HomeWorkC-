﻿// Задача 2. Напишите программу,которая на вход принимает два числа и выдает,какое число больше,а какое меньше

Console.WriteLine("Введите 1-e число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine (number1);
}
if (number2 > number1)
{
    Console.WriteLine(number2);
}