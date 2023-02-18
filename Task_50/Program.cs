// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

Console.Clear();

int a = PutNum("Put num a = ");
int b = PutNum("Put num b = ");

int[,] array = GetArray(3,4,0,9);
System.Console.WriteLine(array);

InputIndex(array,a,b);

int[,] GetArray(int n, int m, int min, int max)
{
   int[,] res = new int[n,m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            res[i,j] = new Random().Next(min,max);
            Console.Write($"{res[i,j]}, ");
        }
        System.Console.WriteLine();
    }
    return res;
} 

void InputIndex(int[,] mass,int a, int b)
{
   if(mass.GetLength(0) > a && mass.GetLength(1) > b)
   {
    Console.WriteLine($"{mass[a,b]}");
   }
   else
   {
   Console.Write($"[{a}, ");
   Console.Write($"{b}] no value");
   }
}

int PutNum(string msg)
{
    System.Console.Write(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}




