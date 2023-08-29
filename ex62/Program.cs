// Задача 62: Заполните спирально массив 4 на 4.
Console.Clear();

int[,] spiralArray = new int[4, 4];
int value = 1;
int rowMin = 0, rowMax = 3, colMin = 0, colMax = 3;

// Заполнение массива в спиральном порядке
while (value <= 16)
{
    for (int i = colMin; i <= colMax; i++)
    {
        spiralArray[rowMin, i] = value;
        value++;
    }
    rowMin++;

    for (int i = rowMin; i <= rowMax; i++)
    {
        spiralArray[i, colMax] = value;
        value++;
    }
    colMax--;

    for (int i = colMax; i >= colMin; i--)
    {
        spiralArray[rowMax, i] = value;
        value++;
    }
    rowMax--;

    for (int i = rowMax; i >= rowMin; i--)
    {
        spiralArray[i, colMin] = value;
        value++;
    }
    colMin++;
}

// Вывод массива на экран
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(spiralArray[i, j] + "\t");
    }
    Console.WriteLine();
}

