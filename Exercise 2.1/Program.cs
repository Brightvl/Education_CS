/* 
Задача 4: Напишите программу, которая принимает на вход 
три числа и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Clear();

Console.WriteLine("Сколько чисел будет?");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int[] nums = new int[n];
el = 0;


while (i < n)
{
    Console.WriteLine($"Введите {i + 1} число");
    int el = Convert.ToInt32(Console.ReadLine());

    Console.Write($"{nums[i]}");
    i++;
} 