// Задача 29: Написать программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

int[] GetMassiv(int count)
{
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        arr[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return arr;
}

void PrintArr(int[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write(")");
}

PrintArr(GetMassiv(8));
