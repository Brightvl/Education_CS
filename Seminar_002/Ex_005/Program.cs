// Напишите программу, которая принимает на вход два числа и 
// проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.Write("1 число = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2 число = ");
int num2 = Convert.ToInt32(Console.ReadLine());


if (num1 == num2*num2)
{
    Console.WriteLine($"Число {num1} является квадратом {num2}");
}
else if (num2 == num1*num1)
{
    Console.WriteLine($"Число {num2} является квадратом {num2}");
}
else
{
    Console.WriteLine("Ни одно число не является квадратом другого");
}