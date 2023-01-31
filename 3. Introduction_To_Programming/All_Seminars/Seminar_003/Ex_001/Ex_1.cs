/* Задача №17. Напишите программу, которая принимает 
на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер 
четверти плоскости, в которой находится эта точка. */

//Решение через функции
Console.Clear();

//Это процедура!
void PrintCord(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("1 четверть");
    else if (x < 0 && y > 0) Console.WriteLine("2 четверть");
    else if (x < 0 && y < 0) Console.WriteLine("3 четверть");
    else if (x > 0 && y < 0) Console.WriteLine("4 четверть");
    else Console.WriteLine("Точка в центре");
}

//Это функция! в данном случае вывел число обозначающее четверть
int PrintCord1(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else if (x > 0 && y < 0) return 4;
    else return 0;
}

Console.WriteLine("Координата X");
int Cord_x = int.Parse(Console.ReadLine());
Console.WriteLine("Координата Y");
int Cord_y = int.Parse(Console.ReadLine());

PrintCord(Cord_x, Cord_y);
PrintCord(5, 6);
PrintCord(-4, -4);


//Альтернативное решение
/* Console.WriteLine("Введите любое число по оси X");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите любое число по оси Y");
int Y = Convert.ToInt32(Console.ReadLine());
if(X < 0)
{
    if(Y < 0)
    {
        Console.WriteLine("Точка находится в 1 четверте");
    }
    else
    {
        Console.WriteLine("Точка находится в 2 четверте");
    }
}
else
{
    if(Y < 0)
    {
        Console.WriteLine("Точка находится в 3 четверте");
    }
    else
    {
        Console.WriteLine("Точка находится в 4 четверте");
    }
} */
