/* Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Sum(int m, int n)
{
    return (m == n) ? n : n + Sum (m,n-1);
}

int start = Prompt("Введите первое число: ");
int finish = Prompt("Введите второе число: ");
Console.Write($"Сумма чисел от {start} до {finish} = {Sum(start, finish)}");