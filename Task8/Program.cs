Console.Write ("Введите целое число: ");
int number = int.Parse (Console.ReadLine()!); //преобразовываем строку и считываем
int even_num = 2;
Console.Write($"{number} -> ");

while (even_num < number - 1)
{
Console.Write($"{even_num}, ");
even_num += 2;
}
Console.Write($"{even_num}");