// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("M");
int m = int.Parse(Console.ReadLine());

System.Console.WriteLine("N");
int n = int.Parse(Console.ReadLine());
int res = SumGap(m,n);
System.Console.WriteLine(res);


int SumGap(int a,int b)
{
    int sum = 0;
    if(b == 1)
    { 
    return a;
    }
     else
     {
      sum =  b + SumGap(a,b - 1);
      return sum;
     }
    
}

