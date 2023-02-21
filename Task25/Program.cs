/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int Prompt (string message)
{
    Console.WriteLine (message);
    int arg = int.Parse (Console.ReadLine()!); 
    return arg;
}

int Pow (int arg1, int arg2)
{
    int mult = 1;
for (int count = 0; count < arg2; count++)
    {
    mult *= arg1;
    }
return mult;
}

bool ValidatePower (int arg2)
{
    if (arg2 < 0)
    {
    Console.WriteLine ("Показатель степени не должен быть меньше 0!");
    return false;
    }
return true;
}

int basis = Prompt ("Введите основание степени: ");
int power = Prompt ("Введите степень: ");

int result = Pow (basis,power);
if (ValidatePower(power))
{
Console.WriteLine($"Число {basis} в степени {power} = {result}");
}