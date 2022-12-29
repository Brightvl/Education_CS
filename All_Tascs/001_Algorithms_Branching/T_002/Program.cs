/* Генерируются два случайных целых числа a и b в интервале [10 – 30].
Если a > b, выводится их разность, eсли a < b, выводится сумма,
eсли a == b, выводится сообщение “числа равны”. (оператор if) */

Console.Clear();

int a = new Random().Next(10, 31);
int b = new Random().Next(10, 31);

if (a > b) {Console.WriteLine(a - b);}
else if (a < b) {Console.WriteLine(b + a);}
else {Console.WriteLine("Числа равны");}

Console.WriteLine(a);
Console.WriteLine(b);