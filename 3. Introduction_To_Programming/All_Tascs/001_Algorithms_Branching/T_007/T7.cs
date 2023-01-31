/* Выводится название предмета по введенной первой букве: ф - физика, м -
математика, и - история, г - география, б - биология (оператор switch). */

Console.WriteLine("Starting");
string less = (Console.ReadLine());
string mes;
switch (less)
{
    case "ф": mes = "Физика"; break; 
    case "м": mes = "Математика"; break; 
    case "и": mes = "История"; break; 
    case "г": mes = "География"; break; 
    case "б": mes = "Биология"; break; 
    default: mes = "Ты ввел погоду"; break; 
}

Console.WriteLine(mes);