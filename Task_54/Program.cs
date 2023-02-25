// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



int[,] array = GetArray(4,4,0,9);
PrintArray(array);

System.Console.WriteLine();

SortAr(array);
PrintArray(array);



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

void SortAr(int[,] mass)
{
        
    for (int i = 0; i < mass.GetLength(0); i++)

    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
              for (int a = 0; a < mass.GetLength(1)-1; a++)
              {
                if(mass[i,a] < mass[i,a+1])
                {
                    int temp = mass[i,a+1];
                    mass[i,a+1] = mass[i,a];
                    mass[i,a] = temp;
                }
              }
        }
                
    }
  
}