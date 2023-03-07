// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Напишите программу, которая будет построчно выводить 
//массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

using System;
using static System.Console;

int Prompt (string message)
{
    WriteLine(message);
    int num = int.Parse (Console.ReadLine()!);
    return num;
}

int[,,] GetArray(int z, int y, int x)
{
    int [,,] array = new int [z,y,x];
    int [] numbers = new int [z*y*x];
    int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       for (int k = 0; k <array.GetLength(2); k++)
       {
        array [i,j,k] = AddNewElement (numbers,count);
        numbers [count] = array [i,j,k];
        count ++;
       }
    }
}
return array;
}

int AddNewElement(int[] array, int count)
{
    int element = new Random().Next(10,100);   
    if (array.Contains(element)) 
    {
        element = AddNewElement(array,count);
    }
    else 
    {
        array[count] = element;   
        count++; 
    }    
    return element;        
}

void PrintArray(int[,,] array)
{
for (int z = 0; z < array.GetLength(0); z++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
       for (int x = 0; x <array.GetLength(2); x++)
       {
           Console.Write ($"{array[z,y,x]}({z},{y},{x}) ");
       }
       WriteLine (" ");
    }
     WriteLine (" ");
}
}

Clear();
int count = Prompt ("Введите количество разделов: ");
int rows = Prompt ("Введите количество строк: ");
int columns = Prompt ("Введите количество столбцов: ");
if (count * rows * columns > 89)
{
WriteLine ("Слишком большой массив, элементы не могут не повторяться!");
}
else
{
int [,,] myArray = GetArray (count,rows,columns);
PrintArray(myArray);
}