// Задача 43. Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

Console.WriteLine("Введите значения k1, b1 для первой прямой (y = k1 * x + b1):");
double k1 = ReadDouble("k1");
double b1 = ReadDouble("b1");

Console.WriteLine("Введите значения k2, b2 для второй прямой (y = k2 * x + b2):");
double k2 = ReadDouble("k2");
double b2 = ReadDouble("b2");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine("Точка пересечения: ({0}, {1})", x, y);


static double ReadDouble(string name)
{
    double value;
    while (true)
    {
        Console.Write("{0} = ", name);
        if (double.TryParse(Console.ReadLine(), out value))
        {
            return value;
        }
        Console.WriteLine("Введено некорректное значение. Попробуйте снова.");
    }
}