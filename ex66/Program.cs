// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
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