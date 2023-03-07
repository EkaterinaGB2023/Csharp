// Показать треугольник Паскаля. 
//*Сделать вывод в виде равнобедренного треугольника.

void FillTriangle (int[,]triangle, int row)
{
    for (int i = 0; i < row; i++)
    {
        triangle[i,0] = 1;
        triangle[i,i] = 1;
    }
    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
           triangle[i,j] = triangle[i-1,j-1] + triangle [i-1,j];
        }
    }
}

/*void PrintTriangle(int [,] triangle, int row)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i,j] != 0)
            {
                Console.Write($"{triangle[i,j],+5}");
            }
        }
        Console.WriteLine();
    }
}*/

void Magic(int [,]triangle, int cellWidth, int row)
{
    int col = cellWidth * row;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition (col, i+1);
            if (triangle [i,j] != 0)
            {
                Console.Write ($"{triangle[i,j],3}");
            }
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i+1);
    }
    Console.WriteLine();
}

Console.Write ("Введите количество рядов треугольника: ");
int row = int.Parse (Console.ReadLine()!);
const int cellWidth = 3;

int [,] array = new int [row,row];
FillTriangle(array,row);
Console.Clear();
Magic(array,cellWidth,row);