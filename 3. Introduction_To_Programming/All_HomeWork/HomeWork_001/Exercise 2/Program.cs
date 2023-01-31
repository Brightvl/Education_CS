/* 
Задача 4: Напишите программу, которая принимает на вход 
три числа и выдает максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Clear();

Console.WriteLine("введи первое число:");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи второе число:");
int Num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи третье число:");
int Num3 = Convert.ToInt32(Console.ReadLine());

if (Num1 > Num2)
{
    if (Num1 > Num3) Console.WriteLine($"Максимальное значение = {Num1} ");
}
else if (Num3 > Num2) {Console.WriteLine($"Максимальное значение = {Num3} ");}
else {Console.WriteLine($"Максимальное значение = {Num2} ");}
