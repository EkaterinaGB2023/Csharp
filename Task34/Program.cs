// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int Prompt (string message)
{
    Console.Write (message);
    int number = int.Parse (Console.ReadLine()!);
    return number;
}

int [] FillArray (int size)
{
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result [i] = new Random().Next(100,1000);
    }
    return result;
}

int FindEven (int []array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array [i] % 2 == 0) 
    count += 1;
}
return count;
}

int size = Prompt("Введите размер массива: ");
int [] arr = FillArray (size);
Console.Write(String.Join(" " , arr));
Console.Write($" -> количество четных чисел в массиве {FindEven(arr)}");