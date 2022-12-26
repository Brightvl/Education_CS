/* По введенному номеру месяца выводится название поры года (зима, весна,
лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр ( if ). */

Console.WriteLine("Введи номер вемени года");

int num = int.Parse(Console.ReadLine());

switch (num)
{
    case 1:  Console.WriteLine("Январь, 2 семестр");        break;
    case 2:  Console.WriteLine("Февраль, 2 каникулы");      break;
    case 3:  Console.WriteLine("Март 2, семестр");          break;
    case 4:  Console.WriteLine("Апрель, 2 семестр");        break;
    case 5:  Console.WriteLine("Май, 2 семестр");           break;
    case 6:  Console.WriteLine("Июнь, сессия");             break;
    case 7:  Console.WriteLine("Июль, каникулы");           break;
    case 8:  Console.WriteLine("Август, 8 семестр");        break;
    case 9:  Console.WriteLine("Сентябрь, 1 семестр");      break;
    case 10: Console.WriteLine("Октябрь, 1 семестр");       break;
    case 11: Console.WriteLine("Ноябрь, 1 семестр");        break;
    case 12: Console.WriteLine("Декабрь, 1 семестр");       break;
    default: Console.WriteLine("Вы не ввели нужное число"); break;
}
