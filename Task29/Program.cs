/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int Prompt (string message)
{
    Console.WriteLine (message);
    int arg = int.Parse (Console.ReadLine()!); 
    return arg;
}

int [] GenerateArray (int length, int minValue, int maxValue)
{
int [] arr = new int [length];
for (int i = 0; i < length; i++)
{
    arr[i] = new Random().Next (minValue,maxValue+1);
}
return arr;
}

void PrintArray (int [] arr)
{
Console.Write ($"[");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr [i]}, ");
}
Console.Write($"{arr [arr.Length-1]}");
Console.Write ($"]");
}

int size = Prompt ("Длина массива:");
int min = Prompt ("Введите начальное значение диапазона: ");
int max = Prompt ("Введите конечное значение диапазона:");
int[] array = GenerateArray (size, min, max);
PrintArray (array);
