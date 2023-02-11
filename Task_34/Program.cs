//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.Clear();

//int[] arr = {234,456,789,980,787,341,284,};

int[] GetArray(int size,int minValue,int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
              res[i] = new Random().Next(minValue,maxValue);
              System.Console.Write($"{res[i]}, ");
    }
    return res;
}






int Number2(int[] num)
{   
    int count = 0;

    for (int i = 0; i < num.Length; i++)
    {
       
        if(num[i] % 2 == 0)
        {
            count = count + 1;
        }
          
    }
    return count; 
}


//EvenNumbr(arr);
int[] result = GetArray(10,100,1000);
System.Console.WriteLine(result);
Console.WriteLine();
int res = Number2(result);
System.Console.WriteLine(res);

