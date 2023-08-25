// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
CalculateColumnAverages(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    Console.WriteLine("Полученный массив:");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void CalculateColumnAverages(int[,] inArray)
{
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");

    int rowCount = inArray.GetLength(0);
    int columnCount = inArray.GetLength(1);

    for (int j = 0; j < columnCount; j++)
    {
        double sum = 0;
        for (int i = 0; i < rowCount; i++)
        {
            sum += inArray[i, j];
        }
        double average = sum / rowCount;
        Console.WriteLine($"Столбец {j + 1}: {average}");
    }
}