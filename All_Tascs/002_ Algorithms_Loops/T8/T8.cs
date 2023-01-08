/* 8. Генерируются случайные числа в интервале (–40, 40) до тех пор,
пока очередное число не превышает 30. Выводятся только нечетные числа */
int i = 1;
while (true)
{
    int rand = new Random().Next(-40, 41);
    if (rand < 30) { if (rand % 2 == 1) Console.WriteLine($"{i}. {rand}"); i++; }
    else { Console.WriteLine($"{i}. {rand} > 30"); break; }
}
