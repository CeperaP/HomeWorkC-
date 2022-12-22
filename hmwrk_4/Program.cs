// Задача 8. Напишите программу,которая на вход принимает число (N),
// а на выходе,показывает все четные числа от 1 до N.

Console.WriteLine("ВВедите число:");
int N = Convert.ToInt32(Console.ReadLine());

int numberA = 0;
for (numberA = 0; numberA <= N; numberA= numberA=numberA+2)
{
Console.WriteLine(numberA);
}
