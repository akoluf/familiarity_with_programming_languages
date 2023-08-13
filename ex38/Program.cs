// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

double[] array = GetArray(15, 1, 100);
Console.WriteLine("Сгенерированный массив:");
Console.WriteLine(string.Join(" ", array));

double min = array[0];
double max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }

    if (array[i] > max)
    {
        max = array[i];
    }
}

double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");

static double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(random.NextDouble() * (maxValue - minValue) + minValue, 3);
    }

    return res;
}
