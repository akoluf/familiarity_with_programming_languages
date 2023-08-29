// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);

Console.WriteLine("Исходный массив:");
PrintArray(array);

int minRowIndex = FindRowWithMinSum(array);

Console.WriteLine("\nИндекс строки с наименьшей суммой элементов:");
Console.WriteLine(minRowIndex);

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

int FindRowWithMinSum(int[,] inputArray)
{
    int numRows = inputArray.GetLength(0);
    int numColumns = inputArray.GetLength(1);

    int minSum = int.MaxValue;
    int minRowIndex = -1;

    for (int i = 0; i < numRows; i++)
    {
        int sum = 0;
        for (int j = 0; j < numColumns; j++)
        {
            sum += inputArray[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRowIndex = i;
        }
    }

    return minRowIndex;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
