// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int Prompt (string message)
{
    Console.Write (message);
    int number = int.Parse (Console.ReadLine()!);
    return number;
}

int [] FillArray (int size, int min, int max)
{
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result [i] = new Random().Next(min,max);
    }
    return result;
}

int  FindSumOdd (int []array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
      sum += array [i];  
    }
    return sum;
}

int size = Prompt ("Введите длину массива: ");
int minValue = Prompt ("Введите начальное значение диапазона: ");
int maxValue = Prompt ("Введите конечное значение диапазона: ");
int [] array = FillArray(size, minValue, maxValue);
Console.Write(String.Join(", " , array));
Console.Write($" -> Сумма чисел на нечетных позициях = {FindSumOdd (array)}");
