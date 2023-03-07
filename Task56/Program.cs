// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

int [] SumRow (int[,] array)
{
int [] result = new int [array.GetLength(0)];
int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[i,j];
    }
    result [i] = sum;
    sum = 0;
}
return result;
}

int FindMinRow (int[] array)
{
    int min = array [0];
    int index = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array [i] < min)
        {
            min = array [i];
            index = i; // для того, чтобы был номер строки относительно пользователя
        }
    }
    return index + 1;
}

Clear();
Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine()!);

Write("Введите количество столбцов массива: ");
int colums = int.Parse(ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 9);
PrintArray(array);
WriteLine();
WriteLine($"{String.Join("; ", SumRow(array))}"); 
//просто для проверки, чтобы видеть суммы каждой строки
WriteLine ($"В строке {FindMinRow(SumRow(array))} наименьшая сумма элементов");