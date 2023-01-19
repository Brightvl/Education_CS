/*Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5->да  
a = 2, b = 10->нет  
a = 9, b = -3->да  
a = -3 b = 9 -> нет)*/

Console.Clear();

Console.WriteLine("Введите первое число");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
double num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == num1 / num2) Console.WriteLine($"{num1} является квадратом числа {num2}");
else Console.WriteLine($"{num1} не является квадратом числа {num2}");

/*Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/

string[] arr = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.Write("Введите номер от 1 до 7 - ");
int numWeek = Convert.ToInt32(Console.ReadLine());
Console.Write(arr[numWeek - 1]);

/*Задача №5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"*/

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = (0 - num);

while (i <= num)
{
    Console.WriteLine(i);
    i++;
}

/*
Задача №7. Напишите программу, которая принимает на 
вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/

Console.Write("Введите трёхзначное число: ");
int numThree = Convert.ToInt32(Console.ReadLine());
int result = (numThree % 10);
Console.Write(result);