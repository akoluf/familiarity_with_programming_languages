// Задача 29: Написать программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

int[] GetMassiv(int count)
{
    int[] arr = new int[count];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArr(int[] array)
