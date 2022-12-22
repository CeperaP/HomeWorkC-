// Задача 6. Напишите программу,которая на вход принимает число
// и выдаёт, является ли число четным (делится ли оно на 2 без остатка).

Console.WriteLine("Введите число для проверки его четности:");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}
