// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// при N < 0, нужно вывести от N до -1
// 5 -> 1, 8, 27, 64, 125

Console.Write ("Введите число: ");
double num = double.Parse(Console.ReadLine()!);
Console.Write ($"{num} -> ");

for (double i = 1; i <= num; i++)
{
    Console.Write ($"{Math.Pow(i, 3)}" + ((i != num) ? ", " : "").ToString());
}