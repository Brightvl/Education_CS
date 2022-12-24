/* Генерируются два случайных целых числа c и d в интервале [-10 – 10].
Если оба числа четные, выводится их частное, если оба нечетные - их сумма,
если одно число четное, а другое нечетное, выводится их произведение ( if ), */

Random rand = new Random();

int c = rand.Next(-10, 11);
int d = rand.Next(-10, 11);

Console.WriteLine(c);
Console.WriteLine(d);

if (c % 2 == 0 && d % 2 == 0)
{
    Console.WriteLine($"Оба четные их частное = {c-d}");
}
else if (c % 2 == 1 && d % 2 == 1)
{
    Console.WriteLine($"Оба не четные из сумма = {c+d}");
}
else{
    Console.WriteLine($"Одно из чисел нечетное, произведение = {c*d}");
}
