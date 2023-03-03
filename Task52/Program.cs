// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt (string message)
{
   Console.Write (message);
   int num = int.Parse (Console.ReadLine()!);
   return num;
}

int [,] GetArray(int m, int n, int minValue, int maxValue)
{
    int [,] result = new int [m, n];
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
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

double [] FindAverage (int [,] array)
{
    double[] result = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double columnSum = 0;
        for (int i = 0; i < array.GetLength(0); i++) 
        {
        columnSum += array[i, j];
        }
        columnSum /= array.GetLength(0);
        result[j] = Math.Round (columnSum, 1);
    }
    return result;
}

int rows = Prompt ("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int min = Prompt ("Введите минимальное значение диапазона: ");
int max = Prompt ("Введите максимальное значение диапазона: ");

int [,] matrix = GetArray (rows, columns, min, max);;
PrintArray (matrix);

double[] result = FindAverage(matrix);
Console.Write ($"Среднее арифметическое каждого столбца = "); 
Console.Write (String.Join("; ", result));

