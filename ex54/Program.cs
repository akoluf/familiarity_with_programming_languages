// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);

Console.WriteLine("Исходный массив:");
PrintArray(array);

SortArrayDescending(array);

Console.WriteLine("\nМассив после упорядочивания:");
PrintArray(array);

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

void SortArrayDescending(int[,] inputArray)
{
    int numRows = inputArray.GetLength(0);
    int numColumns = inputArray.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numColumns - 1; j++)
        {
            for (int k = j + 1; k < numColumns; k++)
            {
                if (inputArray[i, k] > inputArray[i, j])
                {
                    int temp = inputArray[i, j];
                    inputArray[i, j] = inputArray[i, k];
                    inputArray[i, k] = temp;
                }
            }
        }
    }
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
