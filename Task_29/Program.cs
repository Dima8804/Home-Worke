//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]


int[] arr = new int[8];
Random rad = new Random();

PrintArray(arr);

void PrintArray(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = rad.Next(0,10);
        Console.Write($"{array[i]}, " );
       
    }
}     
