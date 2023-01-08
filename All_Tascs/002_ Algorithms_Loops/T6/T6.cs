/* 6. Генерируется 8 случайных чисел в интервале (– 30, 30). Выводятся эти числа
и сообщения: отрицательное – положительное, четное – нечетное ( for, if ). */

for (int i = 1; i < 9; i++)
{
    int rand = new Random().Next(-30, 31);
    if (rand < 0)
    {
        if (rand % 2 == 0) Console.WriteLine($"{i}) {rand} отрицательное, четное.");
        else Console.WriteLine($"{i}) {rand} отрицательное нечетное.");
    }
    else if (rand > 0)
    {
        if (rand % 2 == 0) Console.WriteLine($"{i}) {rand} положительное, четное.");
        else Console.WriteLine($"{i}) {rand} положительное нечетное.");
    }
    else Console.WriteLine($"{i}) {rand} ");
}