// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = GetArray(5,4,0,9);
PrintArray(array);

System.Console.WriteLine();

double[] avareg = AveregeRow(array);
System.Console.Write(avareg);

double line =  FindMinRow(avareg);










int[,] GetArray(int n,int m, int min, int max)
{
    int[,] res = new int[n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            res[i,j] = new Random().Next(min,max);
        }
    }
    return res;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

double[] AveregeRow(int[,] arr)
{
double[] result = new double[arr.GetLength(0)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    double sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum +=arr[i,j];
    }
    result[i] = Math.Round(sum/arr.GetLength(1),2);
    System.Console.Write($"{result[i]} ");
}
return result;

}

double FindMinRow(double[] mas)
{
    int row = 0;
    double min = mas[0];
    for (int i = 1; i < mas.Length; i++)
    {
        if(mas[i] < min)
        {
            min = mas[i];
            row = i + 1;
        }
    } 
    System.Console.WriteLine($" line =>{row}");
    return min;   
}