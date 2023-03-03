// Задача 50. Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
// 1 7 -> такого числа в массиве нет

using System;
using static System.Console;

int Prompt (string message)
{
   Write (message);
   int num = int.Parse (ReadLine()!);
   return num;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

bool Exist (int RowIndex, int ColumnIndex, int NumberOfRows, int NumberOfColumns)
{
    return ((RowIndex < NumberOfRows) && (ColumnIndex < NumberOfColumns));
}

int rows = Prompt ("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");

int [,] array = GetArray (rows, columns, 0, 100);;
PrintArray (array);

int x = Prompt ("Введите номер строки искомого элемента: ");
int y = Prompt("Введите номер столбца искомого элемента: ");
WriteLine(Exist(x, y, rows, columns) ? array [x,y] : "Такого элемента нет!");
