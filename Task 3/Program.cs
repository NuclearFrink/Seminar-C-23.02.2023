// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите трех значное число: ");
int a = int.Parse(Console.ReadLine()),
    b = a%10;
Console.WriteLine($"Крайняя цифра:{b} ");