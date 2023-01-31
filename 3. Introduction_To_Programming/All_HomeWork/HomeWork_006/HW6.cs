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

Number(); //Задача №41
//Альтернатиыное правильно решение 

/* Функция разделяет строку на подстроки и добавляет в массив. 
При этом возвращает целочисленный массив
Разделение с помощью.Split(',', ' ', StringSplitOptions.RemoveEmptyEntries)
В аргументах указана запятая и пробел, а 3 опция удаляет пустые значения.
В итоге в массив записываются только значние без запятых, пробелов и пустых занчений.*/
int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

/* Находит положительные значения в int массиве 
foreach - цикл который перебирает каждое значение из массива
переменная item если больше 0 то увеличиваем значение внутри массива*/
int GerCountPsitiveElements(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 0) count++;
    }
    return count;
}

Console.Clear();
Console.Write("Ввыедите числа через пробел");
int[] numbers = GetArrayFromString(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0 -> {GerCountPsitiveElements(numbers)}");



/* Задача 43: Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0,5) */


// Console.WriteLine("Прямая 1. Введите k1");
// double k1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Прямая 1. Введите b1");
// double b1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Прямая 2. Введите k2");
// double k2 = double.Parse(Console.ReadLine());
// Console.WriteLine("Прямая 2. Введите b2");
// double b2 = double.Parse(Console.ReadLine());

// void CoordinatePointLine(double k1, double k2, double b1, double b2)
// {
//     Console.Write("Уравнение пересечения прямых:\ny = k1 * x + b1\ny = k2 * x + b1\n\n");
//     if (k1 != k2)
//     {
//         double x = (b1 - b2) / (k2 - k1);
//         double y = k1 * x + b1;
//         // double y2 = k2 * x + b2;                 //y2 == y1
//         Console.Write($"Координаты точки пересечения прямых:\nx = {x} y1 = {y}");
//     }
//     else if (k1 == k2 && b1 != b2)
//     {
//         Console.Write("Две прямые параллельны, a значит, они никогда не пересекутся и система не будет иметь решений");

//     }
//     else if (k1 == k2 && b1 == b2)
//     {
//         Console.Write("Две прямые совпали, каждая точка будет решением, а у системы будет бесчисленное множество решений.");
//     }
// }

// CoordinatePointLine(k1, k2, b1, b2);

//альт

//определяет точку пересечния прямых на плосоксти с заданными данными
double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
{
    double[] result = new double[2];
    result[0] = (inB2 - inB1) / (inK1 - inK2);
    result[1] = inK1 * result[0] + inB1;
    return result;
}

Console.Clear();
Console.Write("Введите через пробел b1, k1, b2, k2: ");
string[] f = Console.ReadLine().Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(f[0]);
double k1 = double.Parse(f[1]);
double b2 = double.Parse(f[2]);
double k2 = double.Parse(f[3]);
//Join выводит массив значения массива через пробел в строку
Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));


// РАЗРАБОТКИ 


// string [] sub = {"k1","k2","b1","b2"};
// int i = 0;
// while (i<4)
// {
//     Console.WriteLine($"Введите {sub[i]}");
//     string something = Console.ReadLine();
//     Console.Clear();
//     Console.Write("Уравнение пересечения прямых:\ny = k1 * x + b1\ny = k2 * x + b1\n\n");


//     i++;
// }




// int[] GetFunctionParametersFromUser()
// {
//     int[] result = new int[2];
//     Console.Write("Введите через запятую значения переменных для уравнения A*x + B. Например '3,1' -> ");
//     string userInput = Console.ReadLine();
//     int i = 0;
//     foreach (string numberStr in userInput.Split(','))
//     {
//         if (! int.TryParse(numberStr, out result[i]))
//         {
//             Console.WriteLine($"Не удалось распарсить '{numberStr}', число задано как 0");
//         }
//         i++;
//     }
//     return result;
// }


// double[] FindIntersectionPoints(int[] func1, int[] func2)
// {
//     double[] combinedFunc = new double[2];
//     combinedFunc[0] = func1[0] - func2[0];
//     combinedFunc[1] = func1[1] - func2[1];
//     double x = -(combinedFunc[1]/combinedFunc[0]);
//     double y = func1[0] * x + func1[1];
//     return new double[] {x, y};
// }

// Console.WriteLine("Уравнения y = k1*x + b1 и y = k2*x + b2");
// Console.WriteLine("Для первого уравнения");
// int[] y1 = GetFunctionParametersFromUser();
// Console.WriteLine("Для второго уравнения");
// int[] y2 = GetFunctionParametersFromUser();

// if (y1[0] == y2[0])
// {
//     Console.WriteLine("Угловые коэффициенты равны, функции не пересекаются т.к. Параллельны");
// }
// else
// {
//     Console.WriteLine($"Функции пересекаются в точке ({String.Join(", ", FindIntersectionPoints(y1, y2))})");
// }

// double[] point =  FindIntersectionPoints(y1, y2);
// char[,] graph = new char[10, 10];

// int xStart = (int)point[0] -5;             //x координата точки пересечения 
// int yStart = (int)point[1] -5;             //y координата

// for (int i=0;i<graph.GetLength(0);i++)
// {
//     for (int j=0;j<graph.GetLength(1);j++)
//     {
//         if (j+yStart == Convert.ToInt32(y1[0]*(xStart+ i) + y1[1]) || j+yStart == Convert.ToInt32(y2[0]*(xStart+i) + y2[1]))// graph[i,j] = '*';
//         {
//             Console.Write('*');
//         }
//         else Console.Write(' ');
//     }
//     Console.WriteLine();
// }
