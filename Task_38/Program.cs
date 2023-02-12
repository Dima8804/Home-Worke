//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//
//[3 7 22 2 78] -> 76


Console.Clear();

double[] array = new double[] {4.4,3.5,5.7,7.1,9.8,3.4,9.8,7.5,5.3,1.4,0.9};

void PrintArray(double[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        System.Console.Write($"{mass[i]}, ");
    }
}


double MaxNum(double[] mass)
{
   double max = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max ) max = mass[i];
    }
    return max;
}

double MinNum(double[] mass)
{
    double min = mass[0];
    for (int i = 0; i < mass.Length; i++)
    {
        if(mass[i] < min) min = mass[i];
    }
    return min;
}

double Difer(double max, double min)
{
    double res = max - min;
    return res;
}





PrintArray(array);
double max = MaxNum(array);
System.Console.WriteLine();
Console.WriteLine($"Max number {max}");
double min = MinNum(array);
System.Console.WriteLine($"Min number {min}");
double dif = Difer(max,min);
System.Console.WriteLine($"Difference between numbers {dif}");

