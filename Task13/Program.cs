// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write ("Введите целое число: ");
int number = int.Parse (Console.ReadLine()!);

while (number > 999) 
    {
        number = number / 10;
    }
if (number>0 && number <100)
{
    Console.WriteLine ($"{number} -> Третьей цифры нет");
}
if (number>= 100 && number < 1000)
{
    Console.WriteLine ($"{number} -> {number % 10} ");  
}