/* Введенная цифра (от 0 до 5) выводится прописью (оператор switch). */

Console.WriteLine("Введите число от 0 до 5");
int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 0: Console.WriteLine("Ноль"); break;
    case 1: Console.WriteLine("Один"); break;
    case 2: Console.WriteLine("Два"); break;
    case 3: Console.WriteLine("Три"); break;
    case 4: Console.WriteLine("Четыре"); break;
    case 5: Console.WriteLine("Пять"); break;
    default: Console.WriteLine("Вы сделали что то не то"); break;
}
