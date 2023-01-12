/* 9. Генерируются случайные числа в интервале (0, 20) до тех пор,
пока их сумма не превысит S (вводится с клавиатуры).
Нумеруются и выводятся эти числа и их сумма ( while, if ). */


Console.WriteLine("Введите порог суммы");
int S  = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine($"Предел суммирования = {S}");
int sum = 0;
int i = 0;

while (sum <= S)
{
    int rand = new Random().Next(0, 21);
    if (sum < S - rand) Console.WriteLine($"{++i}. {sum} + {rand} = {sum = sum + rand}");
    else sum = sum + rand;
}
Console.WriteLine($"Программа остановилась на {--i}-й итерации.");