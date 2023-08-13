// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();

int[] array = GetArray(12, 100, 999);
Console.WriteLine("Сгенерированный массив:");
Console.WriteLine(String.Join(" ", array));