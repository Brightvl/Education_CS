//HomeWork №5 16.01.2023

//*Если в функции есть void, то в ней не должно быть return(возврата)

// Создание и возврат массива с рандомными значениями
// N - Длина массива, min и max значение
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

//Вывод массива int
void ShowArrayInt(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

// Функция определения четных чисел в массиве.
int NumEvenInArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}


/* Задача 36: Задайте одномерный массив, заполненный случайными 
числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0 */

//Функция суммирования нечетных чисел в массиве
int SumOddInArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            result += array[i];
        }
    }
    return result;
}


/* Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76 */

//Создание и возврат массива с рандомными значениями типа double
double[] CreateRandomArrayDouble(int N, int start, int end)
{

    double[] RandomArray = new double[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end) + (new Random().NextDouble());
    }
    return RandomArray;
    //double[] CreateRandomArrayDouble(int N, int start, int end, int simbolAfter)
    //double dot = Math.Pow(10, simbolAfter);
    //+ (((new Random().Next()) % Math.Pow(10, simbolAfter)) * 0.01)
}
//Вывод масива double
void ShowArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
//Разница между max и min числами массива
void DiffMaxMinArray(double[] array)
{
    double max = 0;
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"max = {max}, min = {min} разница = {max - min}");
}


Console.Clear();
Console.WriteLine($"HomeWork №5 16.01.2023\nOutput:\n"); 
int[] arrayInt = CreateRandomArray(6, 100, 1000);               //Массив с рандомными числами
Console.Write($"Массив ");
ShowArrayInt(arrayInt);                                         //Отображение массива

Console.WriteLine($"Колличество " +
$"четных чисел в массиве = {NumEvenInArray(arrayInt)}");        //Задача №34

Console.WriteLine($"Cумма "+
$"нечетных чисел массива = {SumOddInArray(arrayInt)}\n");       //Задача №36

Console.Write($"Вещественный массив ");                         //Задача №38
double[] arrayDouble = CreateRandomArrayDouble(6, 100, 1000);   //Создание массива
ShowArrayDouble(arrayDouble);                                   //Отображение
DiffMaxMinArray(arrayDouble);                                   //Разница между min и max в массиве


