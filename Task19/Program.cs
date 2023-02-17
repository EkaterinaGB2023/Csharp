// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите пятизначное число: ");
int num = int.Parse (Console.ReadLine()!);

int a = num / 10000 % 10;
int b = num / 1000 % 10;
int c = num / 10 % 10;
int d = num % 10;

if (a==d && b==c)
{
   Console.WriteLine ($"Число {num} -> палиндром ");
}
else
{
   Console.WriteLine ($"Число {num} -> не палиндром ");    
}