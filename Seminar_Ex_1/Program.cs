/*Задача №1. Напишите программу, которая на вход  
принимает два числа и проверяет, является ли первое число квадратом второго. 
a = 25, b = 5 -> да  
a = 2, b = 10 -> нет  
a = 9, b = -3 -> да  
a = -3 b = 9 -> нет*/ 
 
Console.Clear(); 
 
 
Console.WriteLine("Введите первое число"); 
double num1 = Convert.ToInt32(Console.ReadLine()); 
 
Console.WriteLine("Введите второе число"); 
double num2 = Convert.ToInt32(Console.ReadLine()); 
 
 
 
if (num2 == num1/num2) 
{ 
    Console.WriteLine($"{num1} является квадратом числа {num2}");   
} 
else 
{ 
    Console.WriteLine($"{num1} не является квадратом числа {num2}"); 
}