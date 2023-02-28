// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt (string message)
{
    Console.Write (message);
    double num = double.Parse(Console.ReadLine()!);
    return num;
}

double b1 = Prompt ("Введите коэффициент для первой прямой: ");
double k1 = Prompt ("Введите константу для первой прямой: ");
double b2 = Prompt ("Введите коэффициент для второй прямой: ");
double k2 = Prompt ("Введите константу для второй прямой: ");

double coordX = FindCoordX(b1, k1, b2, k2);
double coordY = k1 * coordX + b1;

double FindCoordX(double b1, double k1, double b2, double k2)
{
    double result = (b2 - b1)/(k1 - k2);
    return result;
}

Console.WriteLine($"Координаты точки пересечения двух прямых: X = {coordX}, Y = {coordY}");


