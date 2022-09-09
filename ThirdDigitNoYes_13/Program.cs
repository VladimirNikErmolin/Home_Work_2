//  Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

if (Math.Abs(number) < 100)
{
    Console.WriteLine($"В введеном числе {number} третьей цифры нет");
}
else if (number > 0)
{
    string thirdDigit = number.ToString();
    Console.WriteLine($"Третья цифра введённого числа {number} имеет значение {thirdDigit[2]}");
}
else
{
    string thirdDigit = number.ToString();
    Console.WriteLine($"Третья цифра введённого числа {number} имеет значение {thirdDigit[3]}");
}
