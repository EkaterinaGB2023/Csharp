// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string PrintNumbers(int number, int i = 1)
{
    if (i == number)
    {
        return number.ToString();
    }
    return PrintNumbers(number, i + 1) + " " + i.ToString();
}

int start = Prompt("Введите число: ");
Console.Write($"Число {start} => {PrintNumbers(start)}");

