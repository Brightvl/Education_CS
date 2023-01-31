/* 7. Генерируется 10 случайных чисел в интервале (– 20, 20). Выводятся только
положительные числа и сообщения: четное - нечетное ( for, if ). */


for (int i = 1; i < 11; i++)
{
    int rand = new Random().Next(-20, 21);
    if (rand > 0 && rand % 2 == 0) Console.WriteLine($"{i}) {rand} четное");
    else if (rand > 0 && rand % 2 == 1) Console.WriteLine($"{i}) {rand} нечетное");
}