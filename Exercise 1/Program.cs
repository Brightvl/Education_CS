/* Задача 2: Напишите программу, которая на вход принимает 
два числа и выдает, какое число большее, а какое меньшее.
a = 5; b = 7 ->  max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Clear();


Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Максимальное = {num1}, Минимальное = {num2}");
}

else
{
    Console.WriteLine($"Максимальное = {num2}, Минимальное = {num1}");
}




