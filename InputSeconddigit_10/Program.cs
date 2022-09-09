// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine()!);

if (Math.Abs(number) < 100 || Math.Abs(number) > 1000)
{
   Console.WriteLine($"Число {number} не является трёхзначным. Введите число соответствующее условиям задачи");
}
else
{
   int secondDigit = number / 10 % 10;
   System.Console.WriteLine($"В введённом числе {number} вторая цифра имеет значение {Math.Abs (secondDigit)}");
}