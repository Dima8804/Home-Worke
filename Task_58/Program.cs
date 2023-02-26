// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = GetArray(2,2,1,9);
PrintArray(matrix1);

System.Console.WriteLine();

int[,] matrix2 = GetArray(2,2,1,9);
PrintArray(matrix2);

int[,] result = ResMatr(matrix1,matrix2);
System.Console.Write(result);






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

int[,] ResMatr(int[,] arr1,int[,] arr2)
{
    int rows = arr1.GetLength(0);
    int colums = arr2.GetLength(1);
    int [,] res = new int[rows, colums];
    if(arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < rows; i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < colums; j++)
            {
                for (int n = 0; n < arr1.GetLength(1) ; n++)
                {
                    res[i,j] += arr1[i,n] * arr2[n,j];
                     
                }
                System.Console.Write($"{res[i,j]} ");
            }
        }

    }
    return res;
}
