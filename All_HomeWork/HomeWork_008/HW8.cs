/* 54 Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой 
строки двумерного массива. */

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

int[,] ArrayStringReduction(int[,] array)
{

    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int coll = 0; coll < array.GetLength(1); coll++)
        {
            for (int k = coll + 1; k < array.GetLength(1); k++)
            {
                if (array[row, k] > array[row, coll])
                {
                    int n = array[row, coll];
                    array[row, coll] = array[row, k];
                    array[row, k] = n;
                }
            }
        }
    }
    return array;
}

/* 56 Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
 */

void MinSummStringInArray(int[,] array)
{
    int min = 0;
    int sum = 0;
    int num = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int coll = 0; coll < array.GetLength(1); coll++)
        {
            sum += array[row, coll];
        }
        Console.WriteLine(sum);
        if (min < sum)
        {
            min = sum;
            num = row+1;
        }
        sum = 0;
    }
    Console.WriteLine(num);
}//Сделать перебор и в переменную записать наименьшее



/* 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента. */
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetThirdArray(int x, int y, int z, int minValue, int maxValue)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return result;
}

void PrintArray1(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}


int[,] array = GetArray(5, 4, 1, 9);
PrintArray(array);
Console.WriteLine();
ArrayStringReduction(array);                        //54
PrintArray(array);
Console.WriteLine();

MinSummStringInArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();





int[,,] arrayThird = GetThirdArray(4, 4, 4, 10, 100); //60
PrintArray1(arrayThird);

