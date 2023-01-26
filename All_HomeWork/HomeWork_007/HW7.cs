/*  Задача 47: Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

//Создает массив с рандомными значениями типа double
double[,] CreateNewRandomArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return result;
}
//Выводит на экран массив типа double
void PrintArray<T>(T[,] array) //T - Джинерик
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //интерполяция - :E3, знаки после запятой
            Console.Write($"{array[i, j]:N1}  ");
        }
        Console.WriteLine();
    }

}
// //Выводит на экран массив типа int
// void PrintArrayInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             //интерполяция - :E3, знаки после запятой
//             Console.Write($"{array[i, j]}  ");
//         }
//         Console.WriteLine();
//     }

// }

/* Задача 50: Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого 
элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

//Отображает элемент двумерного массива по индексу
void FindElementInArray(double[,] array)
{
    Console.Write("Введите столбец -> ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите строку -> ");
    int row = Convert.ToInt32(Console.ReadLine());
    if (row > array.GetLength(0) || column > array.GetLength(1))
    { Console.WriteLine($"Такого числа нет в массиве"); }
    else Console.WriteLine($"Искомое число {array[row - 1, column - 1]:N3}");
}


/* Задача 52: Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

//Создает новый массив int типа
int[,] CreateNewRandomArrayInt(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
//Определяет среднее арифметичнское у столбцов массива
void AverageColoumnArray(int[,] array)
{
    double average = array[0, 0];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 1; j < array.GetLength(0); j++)
        {
            average += array[i, j];
        }
        Console.Write($"{average / array.GetLength(1)}  ");
    }
}



Console.Clear();
Console.WriteLine("Двумерный массив типа double");
double[,] randomArray = CreateNewRandomArray(5, 4, 1, 10);      //Задача №47
PrintArray(randomArray);
Console.WriteLine("\nПоиск элемента по индексу:");
FindElementInArray(randomArray);                                //Задача №50
Console.WriteLine("\nОпределение среднего арифметического столбцов int массива:");
int[,] randomArrayInt = CreateNewRandomArrayInt(5, 5, 1, 10);
PrintArray(randomArrayInt);
Console.WriteLine();
AverageColoumnArray(randomArrayInt);                            //Задача №52