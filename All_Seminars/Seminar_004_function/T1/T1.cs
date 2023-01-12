/* Задача 24: Напишите программу, которая принимает на вход число 
(А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
 */

// через функци на int 
Console.Clear();

int a = int.Parse(Console.ReadLine());

void Sum(int num)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(num); i++) sum+= i;
    Console.Write($"Сумма чисел равна {sum}");
}

Sum(a);
