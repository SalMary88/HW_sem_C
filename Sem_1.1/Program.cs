// Задача 4
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());
Console.WriteLine($"max = {a}");
if (b > a) Console.WriteLine($"max = {b}");
if (c > a) Console.WriteLine($"max = {c}");