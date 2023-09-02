// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до M.

Console.Clear();
Console.Write("Введите число M: ");
if (!int.TryParse(Console.ReadLine(), out int m))
{
    Console.WriteLine("Некорректный ввод числа M. Пожалуйста, введите целое число.");
    return;
}

Console.Write("Введите число N: ");
if (!int.TryParse(Console.ReadLine(), out int n))
{
    Console.WriteLine("Некорректный ввод числа N. Пожалуйста, введите целое число.");
    return;
}
