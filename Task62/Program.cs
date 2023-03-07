// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

using System;
using static System.Console;

int Prompt (string message)
{
    WriteLine(message);
    int num = int.Parse (Console.ReadLine()!);
    return num;
}

int[,] GetSpiralArray(int row, int col)
{
    int[,] spiralArray = new int[row, col];
    int i = 0;   // стартовая позиция рядов
    int j = 0;   // стартовая позиция столбцов
    int step = 1;   // шаг для передвижения по матрице
    int num = 1;   // число, с которого начинается заполнение
    
    while (num <= row * col) 
    {
        while (j + step >= 0 && j + step < col)
        {
            if (spiralArray[i, j] == 0)
            {
                spiralArray[i, j] = num;
                num++; 
            }         
            if (num > row * col ||  spiralArray[i, j + step] != 0) break;   
// условия для досрочного выхода из цикла - закончились пустые ячейки
            j += step;
        }
        
        while (i + step >= 0 && i + step < row)
        {           
            if (spiralArray[i, j] == 0)
            {
                spiralArray[i, j] = num;
                num++;
            }          
            if (num > row * col || spiralArray[i + step, j] != 0) break;   
// условия для досрочного выхода из цикла - закончились пустые ячейки                
            i += step;
        }
        step *= -1;   // в конце итерации внешнего цикла меняем направление движения
    }    
    return spiralArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 5}");
        }
        WriteLine();
    }
}

Clear();
int rows = Prompt ("Введите количество строк: ");
int columns = Prompt ("Введите количество столбцов: ");
int [,] myArray = GetSpiralArray (rows,columns);
PrintArray(myArray);