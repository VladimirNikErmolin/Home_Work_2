﻿//  Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели");
int number = int.Parse(Console.ReadLine()!);

if (number < 1 || number > 7)
{
    Console.WriteLine($"Такой день недели не существует. Введите цифру соответствующюю условиям задачи");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine($"Да. Эта цифра, обозначающую день недели, соответствует выходному дню.");
}
else
{
    Console.WriteLine($"Нет. Эта цифра, обозначающую день недели, не соответствует выходному дню.");
}

