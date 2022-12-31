/* Повторяются вычисления и вывод площади круга(S = π × r^2) по вводимому радиусу r
до тех пор, пока не введена буква z или Z . */


double S = 0, pi = 3.14;
string r = "";
while (true)
{
    Console.Write("Введите радиус ");
    r = Console.ReadLine();
    if (r == "z" || r == "Z") break;
    if (double.TryParse(r, out double n))
    {
        S = pi * n * n;
        Console.WriteLine($"Площадь круга = {S}");
    }
}
