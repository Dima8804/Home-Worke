//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.//

//0, 7, 8, -2, -2 -> 2//

//1, -7, 567, 89, 223-> 3

Console.Clear();

int[] n = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

int result = Sum0(n);
System.Console.WriteLine(result);

int Sum0(int[] array)
{
    int res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            res = res + 1;
        }

    }
    return res;
}
