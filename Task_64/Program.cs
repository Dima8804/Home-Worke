// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int num = int.Parse(Console.ReadLine());
NaturalNambers(num);




void NaturalNambers(int num, int start = 1)
{
   System.Console.Write($"{start} ");
if(start == num)
{
   System.Console.Write($",");
   return;
}
else
   {
      System.Console.Write($",");
        NaturalNambers(num,start + 1);
   } 
    
}