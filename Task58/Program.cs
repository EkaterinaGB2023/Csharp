// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using System;
using static System.Console;

int Prompt (string message)
{
    WriteLine(message);
    int num = int.Parse (Console.ReadLine()!);
    return num;
}

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

int [,] Multiplication (int [,] array1, int [,] array2)
{
int [,] result = new int [array1.GetLength(0), array2.GetLength(1)];
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        for (int k = 0; k < array2.GetLength(0); k++)
        {
        result [i,j] += array1 [i,k] * array2 [k,j]; 
        }
    }
}
return result;
}

Clear();
int rows1 = Prompt ("Введите количество строк первой матрицы: ");
int columns1 = Prompt ("Введите количество столбцов первой матрицы: ");
int rows2 = Prompt ("Введите количество строк второй матрицы: ");
int columns2 = Prompt ("Введите количество столбцов второй матрицы: ");

if (columns1 != rows2)
{
    Console.WriteLine ("Умножение данных матриц невозможно!");
}
else
{
int[,] matrix1 = GetArray(rows1, columns1, 0, 9);
int[,] matrix2 = GetArray(rows2, columns2, 0, 9);
WriteLine ("Первая матрица:");
PrintArray(matrix1);
WriteLine();
WriteLine ("Вторая матрица:");
PrintArray(matrix2);
WriteLine();
WriteLine ("Результирующая матрица");
PrintArray (Multiplication(matrix1, matrix2));
}