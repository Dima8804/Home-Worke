//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет




int count = 0;

while(count <= 20)
{ 

int a = new Random().Next(1,8);

if(a > 5 )
{

    Console.WriteLine($"{a} -> yes ");
}
else
{
    Console.WriteLine($"{a} -> no ");
}
count++;
}
