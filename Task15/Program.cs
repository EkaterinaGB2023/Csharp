// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write ("Введите число: ");
int day = int.Parse (Console.ReadLine()!);

if ((day == 6) || (day == 7))
{
    Console.WriteLine ($"{day} -> выходной");
}
else if ((day <= 0) || (day >= 8))
{
       Console.WriteLine ($"{day} -> это не день недели"); 
}
else
{
        Console.WriteLine ($"{day} -> рабочий");
}
