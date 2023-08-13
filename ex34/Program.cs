// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

int[] array = GetArray(12, 100, 999);
Console.WriteLine("Сгенерированный массив:");
Console.WriteLine(String.Join(" ", array));

int evenCount = GetEvenCount(array);
Console.WriteLine($"Четных чисел: {evenCount}");

static int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = random.Next(minValue, maxValue + 1);
    }

    return res;
}

static int GetEvenCount(int[] arr)
{
    int evenCount = 0;

    foreach (int el in arr)
    {
        if (el % 2 == 0)
        {
            evenCount++;
        }
    }

    return evenCount;
}
