// Задача 25: Написать цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
int numA = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int numB = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");
int result = PowerOf(numA, numB);
Console.WriteLine($"{numA} в степени {numB} = {result}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int PowerOf(int num, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= num;
    }
    return result;
}
