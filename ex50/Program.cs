// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.Write("Введите позицию элемента (x, y): ");
string positionInput = Console.ReadLine();
if (TryParsePosition(positionInput, out int x, out int y))
{
    if (IsValidPosition(array, x, y))
    {
        Console.WriteLine("Искомый элемент:");
        PrintArrayWithHighlightedElement(array, x, y);
    }
    else
    {
        Console.WriteLine("Ошибка: указанная позиция находится за границами массива.");
    }
}
else
{
    Console.WriteLine("Ошибка: некорректный формат позиции.");
}

static int[,] GetArray(int m, int n, int minValue, int maxValue)
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

static void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static bool TryParsePosition(string positionInput, out int x, out int y)
{
    x = 0;
    y = 0;

    string[] coordinates = positionInput.Split(',');

    if (coordinates.Length != 2)
        return false;

    if (!int.TryParse(coordinates[0].Replace("(", "").Trim(), out x))
        return false;

    if (!int.TryParse(coordinates[1].Replace(")", "").Trim(), out y))
        return false;

    return true;
}

static bool IsValidPosition(int[,] array, int x, int y)
{
    return x >= 0 && x < array.GetLength(0) && y >= 0 && y < array.GetLength(1);
}

static void PrintArrayWithHighlightedElement(int[,] array, int x, int y)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == x && j == y)
                Console.Write($"[{array[i, j]}] ");
            else
                Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// искомый элемент если он имеется обводится квадратными скобками