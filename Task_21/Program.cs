//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Put number A1");
int ax = int.Parse(Console.ReadLine());

Console.WriteLine("Put number A2");
int ay = int.Parse(Console.ReadLine());

Console.WriteLine("Put number A3");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Put number B1");
int bx = int.Parse(Console.ReadLine());

Console.WriteLine("Put number B2");
int by = int.Parse(Console.ReadLine());

Console.WriteLine("Put number B3");
int bz = int.Parse(Console.ReadLine());

double resalt = 0;
int d = ax - bx;
int e = ay - by;
int f = az - bz;


resalt = Math.Sqrt((d*d)+(e*e)+(f*f));
Console.WriteLine(resalt);