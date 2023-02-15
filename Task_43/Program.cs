//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = Input("Put number b1");
double k1 = Input("Put number k1");
double b2 = Input("Put number b2");
double k2 = Input("Put number k2");

int Input(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}


double sum = k1 + (k2 * -1);     ///
double sum2 = b1 + (b2 * -1);     /// нахождение x
double x = (sum2 * -1) / sum;   ////

double y = k2 * x + b2;   ///нахождение y

System.Console.WriteLine($"{x} {y}");
















