// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] array = GetArray(10, 10, 1, 10);
System.Console.WriteLine(array);

double sum = Avarege(array);
Console.WriteLine(sum);



int[,] GetArray(int n, int m, int min, int max)
{
    int[,] res = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            res[i, j] = new Random().Next(min, max);
            Console.Write($"{res[i, j]}, ");
        }
        System.Console.WriteLine();
    }
    return res;
}

double Avarege(int[,] mass)
{
    double sum0 = 0;
    
    double sum1 = 0;
   
    double sum2 = 0;
    
    double sum3 = 0;
    

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (j == 0) sum0 += mass[i, j];
            if (j == 1) sum1 += mass[i, j];
            if (j == 2) sum2 += mass[i, j];
            if (j == 3) sum3 += mass[i, j];
        }
    }
    Console.WriteLine($"{sum0/mass.GetLength(0)}, {sum1/mass.GetLength(0)}, {sum2/mass.GetLength(0)}, {sum3/mass.GetLength(0)}");
   
    return sum0;
}