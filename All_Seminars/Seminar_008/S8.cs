/* 53 Задайте двумерный массив. Напишите программу,которая 
поменяет местами первую и последнюю строку массива
 */

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int[,] SwapArray(int[,] array)
{
    int n;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        n = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = n;
    }
    return array;
}



/* 55 Задайте двумерный массив. Напишите программу,которая 
заменяет строки на столбцы. В случае, если 
это невозможно, программа должна вывести сообщение 
для пользователя
 */

int[,] ReverseArray(int[,] array)
{
    int[,] result = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
        }
    }
   
    return result;
}


/*  57 Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз 
встречается элемент входных данных
 */

/* Задача 59: Задайте двумерный массив из целых чисел. Напишите 
программу, которая удалит строку и столбец, напересечении которых 
расположен наименьший элементмассива.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получимследующий массив:
9 4 2
2 2 6
3 4 7 */

/* 61 Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника */


int[,] array = GetArray(5, 4, 1, 9);
PrintArray(array);
Console.WriteLine();
SwapArray(array);                       //#53
PrintArray(array);
int[,] newArray = ReverseArray(array); //#55 Обязательно нужно перезаписать
// потому что мы возвращаем значение а не массив
Console.WriteLine();
PrintArray(newArray);
