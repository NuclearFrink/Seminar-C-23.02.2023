// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a*a == b) {
    Console.WriteLine("да");
}
else {
    Console.WriteLine("нет");
}