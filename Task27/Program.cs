/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int Prompt (string message)
{
    Console.WriteLine (message);
    int arg = int.Parse (Console.ReadLine()!); 
    return arg;
}

int CountSumOfDigits (int num)
{
int sum = 0;
while (num > 0)
{
    sum = sum + (num % 10);
    num /= 10; 
}
return sum;
}

int number = Prompt ("Введите число: ");
int result = CountSumOfDigits (number);
Console.WriteLine ($"Сумма цифр числа {number} равна {result}");