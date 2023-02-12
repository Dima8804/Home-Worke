//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0



Console.Clear();

int[] RandomArray(int size,int minValue,int maxValue )
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue,maxValue);
        Console.Write($"{result[i]}, ");
    }
    return result; 
}



 int SumOddNumbers(int[] array)
{
    int sum = 0;

   for (int i = 0; i < array.Length; i++)
   {
       if(i % 2 == 0)
       {}
              else
        {
                    sum = sum + array[i];
        }            
   }
   return sum;
}

int[] arr = RandomArray(4,0,10);
Console.WriteLine(arr);
int odd = SumOddNumbers(arr);
System.Console.WriteLine();
System.Console.WriteLine(odd);