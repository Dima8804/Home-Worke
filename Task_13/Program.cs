//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
Console.WriteLine("Put number");
int a =int.Parse(Console.ReadLine());

if(a > 0 & a < 99 )
{
    Console.WriteLine($"{a}-> dont have number");
}
if(a > 100 & a < 999)
{
    int c = a % 10;
    Console.WriteLine($"{a} -> {c}");
}
if(a > 1000 & a < 9999)
{
    int b = a / 10;
    int d = b % 10;
    Console.WriteLine($"{a} -> {d}");
}
if(a >= 10000)
{
    int e = a / 100;
    int f = e % 10;
    Console.WriteLine($"{a} -> {f}");
}
