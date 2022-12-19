// Напишите программу, которая будет 
// принимать на вход два числа и выводить, 
// является ли второе число кратным 
// первому. Если число 2 не кратно 
// числу 1, то программа выводит остаток 
// от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


Console.WriteLine("Первое число = ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число = ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 % num_2 == 0)
{
    Console.WriteLine($"Число {num_2} кратно {num_1}");
}
else
{
    Console.WriteLine ($"Число {num_2}Не кратно {num_1}");
}


