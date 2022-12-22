/* Задача 10: Напишите программу, которая принимает 
 на вход трёхзначное число и на выходе показывает 
 вторую цифру этого числа.

456 -> 5
782 -> 8 
918 -> 1
*/

// Console.Clear();
// int num = Random().Next(100, 1000);
// int secondNumber = num/ 10%10;
// Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");

Console.Clear();

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1000 && num > 99)
{
    int num_2 = ((num % 100) / 10);
    Console.WriteLine(num_2);
}
else
{
    Console.WriteLine("Вы ввеели не трехзначное значное число ало");
}



