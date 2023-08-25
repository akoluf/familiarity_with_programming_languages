// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);


static double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double value = Math.Round((random.NextDouble() * (maxValue - minValue) + minValue), 2);
            result[i, j] = random.Next(2) == 0 ? value : -value; // Случайный выбор знака числа
        }
    }

    return result;
}

static void PrintArray(double[,] inArray)
{
    int m = inArray.GetLength(0);
    int n = inArray.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{inArray[i, j]:0.00} ");
        }
        Console.WriteLine();
    }
}