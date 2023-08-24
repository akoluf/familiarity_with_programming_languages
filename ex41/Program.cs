// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

Console.Write("Введите числа, разделяя их пробелами: ");
string input = Console.ReadLine() ??"";

string[] numbers = input.Split(' ');

Console.WriteLine("Массив чисел: ");
foreach (string number in numbers)
{
    Console.Write(number + " ");
}

int count = numbers.Length;
Console.WriteLine($"\nБыло введено {count} чисел.");

Console.ReadLine(); 


