// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

using System;
using static System.Console;

int Prompt (string message)
{
   Write (message);
   int num = int.Parse (Console.ReadLine()!);
   return num;
}

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{Math.Round(inArray[i,j],1)}; ");
        }
        WriteLine();
    }
}

int rows = Prompt ("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int min = Prompt ("Введите минимальное значение диапазона: ");
int max = Prompt ("Введите максимальное значение диапазона: ");

double [,] array = GetArray (rows, columns, min, max);;
PrintArray (array);
