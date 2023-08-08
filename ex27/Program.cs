// Задача 27: Написать программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int sum = GetSumDigits(num);
Console.WriteLine($"{num} -> {sum}");

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

int GetSumDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}