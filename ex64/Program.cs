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

if (m >= n)
{
    Console.WriteLine("Число N должно быть больше числа M.");
    return;
}

string numbersString = GetNatur(n, m);

Console.WriteLine(numbersString);
Console.WriteLine("...............");


static string GetNatur(int startNum, int endNum)
{
    if (startNum == endNum) return startNum.ToString();

    return startNum + " " + GetNatur(startNum - 1, endNum);
}
