/* Вычисляется сумма всех нечетных натуральных чисел от n1 до n2
(n1 и n2 вводятся с клавиатуры, цикл for). */

Console.Write("Введите 1 число = ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Введите 2 число = ");
int n2 = int.Parse(Console.ReadLine());
int sum = 0;

for (int i = n1; i <= n2; i++) if (i % 2 == 1) sum = sum + i;

Console.WriteLine("n1 = {0} \nn2 = {1} \nsum = {2}", n1, n2, sum);