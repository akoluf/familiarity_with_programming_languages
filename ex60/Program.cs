// задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();

int[,,] array = GetArray(3, 3, 3, 10, 99);

PrintArrayWithIndexes(array);

int[,,] GetArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x, y, z];
    List<int> usedNumbers = new List<int>();

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int number;
                do
                {
                    number = new Random().Next(minValue, maxValue + 1);
                } while (usedNumbers.Contains(number));

                result[i, j, k] = number;
                usedNumbers.Add(number);
            }
        }
    }

    return result;
}

void PrintArrayWithIndexes(int[,,] array)
{
    int xLength = array.GetLength(0);
    int yLength = array.GetLength(1);
    int zLength = array.GetLength(2);

    for (int i = 0; i < xLength; i++)
    {
        for (int j = 0; j < yLength; j++)
        {
            for (int k = 0; k < zLength; k++)
            {
                Console.WriteLine($"[{i}, {j}, {k}]: {array[i, j, k]}");
            }
        }
    }
}