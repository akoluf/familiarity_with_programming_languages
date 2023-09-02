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

if (m >= n)
{
    Console.WriteLine("Число N должно быть больше числа M.");
    return;
}

int sum = GetNaturSum(m, n);

Console.WriteLine("Сумма натуральных чисел: " + sum);
Console.WriteLine("...............");

static int GetNaturSum(int startNum, int endNum)
{
    if (startNum == endNum) return startNum;

    return startNum + GetNaturSum(startNum + 1, endNum);
}