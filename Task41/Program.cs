//  Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int [] Convertator (string [] message)
{
    int [] nums = new int [message.Length];
    for (int i = 0; i < message.Length; i++)
            {
            nums [i] = Convert.ToInt32(message[i]);
            }
    return nums;
}

int CountPos (int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> 0) result +=1;
    }
return result;
}

Console.WriteLine ("Введите числа через пробел: ");
string[] str = Console.ReadLine().Split(' ');
int [] numbers = Convertator (str);
Console.Write($"[{String.Join(", " , numbers)}]");
Console.Write ($"-> В данном массиве {CountPos(numbers)} положительных чисел ");
