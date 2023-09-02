// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
Console.Clear();
Console.Write("Введите число m: ");
if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
{
    Console.WriteLine("Некорректный ввод числа M. Пожалуйста, введите положительное целое число.");
    return;
}

Console.Write("Введите число n: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
{
    Console.WriteLine("Некорректный ввод числа N. Пожалуйста, введите положительное целое число.");
    return;
}

int result = CalculateAckermannFunction(m, n);

Console.WriteLine("A(m,n) = " + result);
Console.WriteLine("...............");


static int CalculateAckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return CalculateAckermannFunction(m - 1, 1);
    }
    else
    {
        return CalculateAckermannFunction(m - 1, CalculateAckermannFunction(m, n - 1));
    }
}