//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Put number");
int N = int.Parse(Console.ReadLine());

double count = 1;

while(N >= count)
{
    Console.Write(Math.Pow(count, 3) + ",");
    count++;
}