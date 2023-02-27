// Задача 2
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if (a > b) Console.WriteLine($"max = {a}, min = {b}");
if (b > a) Console.WriteLine($"max = {b}, min = {a}");