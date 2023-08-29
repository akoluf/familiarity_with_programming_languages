// задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();

int[,] array1 = GetArray(5, 5, 0, 10);
int[,] array2 = GetArray(5, 5, 0, 10);

Console.WriteLine("Первая матрица:");
PrintArray(array1);

Console.WriteLine("\nВторая матрица:");
PrintArray(array2);

int[,] result = MultiplyArrays(array1, array2);

Console.WriteLine("\nРезультат умножения матриц:");
PrintArray(result);

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

int[,] MultiplyArrays(int[,] array1, int[,] array2)
{
    int rows1 = array1.GetLength(0);
    int columns1 = array1.GetLength(1);
    int columns2 = array2.GetLength(1);

    int[,] result = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            for (int k = 0; k < columns1; k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }

    return result;
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