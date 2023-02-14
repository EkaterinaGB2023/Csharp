// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100,1000);

int second = number / 10;
int second2 = second % 10;

Console.WriteLine ($"{number} -> {second2}");