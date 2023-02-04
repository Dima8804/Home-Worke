//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.Clear();

Console.WriteLine("Put number");
int num = int.Parse(Console.ReadLine());
int resalt = num;
int b = 0;
int c = 0;
int a = num ;
int d = 0;
int e = 0;

while(num > 99 )
{
   num = num / 10;
    
}
a = a % 100;

    b = num / 10;
    c = num % 10;

 d = a / 10;
 e = a % 10;

  
if( b + c == d + e )
{
    Console.WriteLine($"{resalt} -> yes");
}  
else
{
    Console.Write($"{resalt} -> no");
}  
