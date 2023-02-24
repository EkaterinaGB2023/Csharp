// Задача 38:Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76

int Prompt (string message)
{
    Console.Write (message);
    int number = int.Parse (Console.ReadLine()!);
    return number;
}

double [] FillArray (int size, int min, int max)
{
    double [] result = new double [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min,max);
    }
    return result;
}

double FindMinimum (double []array)
{
double min = array [0];
for (int i = 1; i < array.Length; i++)
{
        if (array[i] < min) 
        {
            min = array [i];
        }
}
return min;
}

double FindMaximum (double []array)
{
  double max = array [0];
for (int i = 1; i < array.Length; i++)
{
        if (array[i] > max) 
        {
            max = array [i];
        }
}  
return max;
}

int size = Prompt ("Введите длину массива: ");
int minValue = Prompt ("Введите начальное значение диапазона: ");
int maxValue = Prompt ("Введите конечное значение диапазона: ");
double [] array = FillArray(size, minValue, maxValue);
Console.Write(String.Join(", " , array));
Console.Write($" -> Разность максимального и минимального элементов = {FindMaximum (array) - FindMinimum (array)}");