// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();

int[] array = GetArray(20, -200, 200);
Console.WriteLine("Сгенерированный массив:");
Console.WriteLine(String.Join(" ", array));

int oddPositionSum = GetOddPositionSum(array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {oddPositionSum}");

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

static int GetOddPositionSum(int[] arr)
{
    int oddPositionSum = 0;

    for (int i = 1; i < arr.Length; i += 2)
    {
        oddPositionSum += arr[i];
    }

    return oddPositionSum;
}