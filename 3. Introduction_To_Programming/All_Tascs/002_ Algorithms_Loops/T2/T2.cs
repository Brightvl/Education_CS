/* Вычисляется сумма квадратов n натуральных чисел, начиная с k
(вводятся k и n, цикл for). */

Console.Write("С какого числа пойдет отсчет? = ");
int k = int.Parse(Console.ReadLine());
Console.Write("Сколько чисел посчитать? = ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = k; i < k+n; i++){sum = sum + (i*i);}

Console.WriteLine($"Сумма квадратов натуральных чисел начиная с {k}-го по {k+n-1}-ое, равна {sum}");