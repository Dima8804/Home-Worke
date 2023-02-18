// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();

double[,] array = GetArray(3,4,0,9);
System.Console.WriteLine(array);


double[,] GetArray(int n, int m, int min, int max)
{
    double[,] res = new double[n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            res[i,j] = Math.Round (new Random().NextDouble() + new Random().Next(min,max),1);
            Console.Write($"{res[i,j]}, ");
        }
        System.Console.WriteLine();
    }
    return res;
} 