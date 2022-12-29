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

string[] array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
Console.WriteLine($"Type month number: ");
int month = int.Parse(Console.ReadLine());


if (month > 0 && month < 3 || month == 12)
{
    Console.WriteLine("Winter");
    if (month == 1 || month == 12) { Console.WriteLine("Session but then Holidays!"); }
    else {Console.WriteLine("Holidays");}
}
else if (month > 2 && month < 6)
{
    Console.WriteLine("Spring");
    if (month < 5) { Console.WriteLine("2nd term");}
    else { Console.WriteLine("Session but then Holidays!");}
}
else if (month > 5 && month < 9)
{
    Console.WriteLine("Summer");
    if (month > 6) { Console.WriteLine("Holidays");}
    else { Console.WriteLine("Session but then Holidays!");}
}
else if (month > 8 && month < 12)
{
    Console.WriteLine("Autumn");
    Console.WriteLine("1nd term");
}
else { Console.WriteLine($"Hey dude, wake up!"); }