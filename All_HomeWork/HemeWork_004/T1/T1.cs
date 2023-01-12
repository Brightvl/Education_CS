/*  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */

Console.Write("Введите 1-е число = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите 2-е число = ");
int b = int.Parse(Console.ReadLine());

void Multiplicate(int a, int b)
{
    int mult = 1;
    for (int i = 1; i <= b; i++)
    {
        mult *= a;
    }
    Console.Write(mult);
}

Multiplicate(a, b);
