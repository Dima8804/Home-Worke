//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.Clear();

Console.WriteLine("Put number A");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Put number B");
int b = int.Parse(Console.ReadLine());
int num = 1;


    for (int i = 0; i < b; i++)
    {
        num = num * a;
   
    
    }
   Console.WriteLine(num);


