// задача 4. Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.

Console.WriteLine("Введите 1-е число:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е число:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3-е число:");
int number3 = Convert.ToInt32(Console.ReadLine());

int Maxnumber = 0;


if (number1 > number2)
{
    Maxnumber = number1;
}
else
{
    Maxnumber = number2;
}

if (number3 > Maxnumber)

{
    Maxnumber = number3;
}    

else
{
    Console.WriteLine(Maxnumber);
}

Console.WriteLine(Maxnumber);



