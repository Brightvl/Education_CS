/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


void Number()
{
    Console.Clear();
    Console.WriteLine("Для остановки программы нажите 'q'.\nВведите числа больше нуля: ");
    bool GoCode = true;
    int result = 0;
    while (GoCode)
    {
        string m = Console.ReadLine();
        if (int.TryParse(m, out int n) && Convert.ToInt32(m) > 0)
        {
            result++;
        }
        else if (m == "q")
        {
            Console.Write($"Вы нажали 'q', Программа остановилась. Введено {result} значений.\n");
            GoCode = false;
        }
    }
}

/* Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
x
b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5) */


Console.Write("Уравнение отрезков: y = k * x + b ");
Console.Write("Введите k1");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b1");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k2");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите b2");
int b2 = int.Parse(Console.ReadLine());

if (k1 != k2)
{
    int x =
}
else if (k1 == k2 && b1 != b2)
{
    /*     Две прямые могут быть параллельны, а значит, они никогда не 
        пересекутся и система не будет иметь решений. 
        y = k1 * x + b1, y = k2 * x + b2; 
        y - y = k1*x + b1 - (k2*x + b2)
        0 = 
        x
        */
}
else if (k1 == k2 && b1 == b2)
{
    /* Две прямые могут совпасть, и тогда каждая точка будет решением, 
    а у системы будет бесчисленное множество решений. */
}
//Number(); //Задача №41


