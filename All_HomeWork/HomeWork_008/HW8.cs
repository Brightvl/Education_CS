/* 54. Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой 
строки двумерного массива. */

void PrintArray(int[,] inArray) //Отображение массива
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

int[,] GetArray(int m, int n, int minValue, int maxValue) //Создание массива
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

int[,] ArrayStringReduction(int[,] array) //Элементы в строке по порядку
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

/* 56. Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
 */

void MinSummStringInArray(int[,] array) //Отображение строки с мин суммой
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
        Console.Write($"{sum} ");
        if (min == 0) min = sum;
        else if (min > sum)
        {
            min = sum;
            num = row + 1;
        }
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма в {num}-й строке");
}

/* 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB) //Умножение матриц
{
    //Колличество столбцов первой матрицы должно быть равно колличеству строк 2 матрицы
    //Должна умножаться строка на столбец
    int rowsA = matrixA.GetLength(0);
    int colsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int colsB = matrixB.GetLength(1);

    if (colsA != rowsB)
    {
        throw new Exception("Ошибка, столбец матрицы А не совпадает со строкой матрицы B");
        //Для того чтобы в консоль выдалась информация о не совпадении
    }

    int[,] result = new int[rowsA, colsB]; //Результирующая матрица

    for (int i = 0; i < rowsA; i++) //строка 1 матрицы
    {
        for (int j = 0; j < colsB; j++) //столбец второй
        {
            for (int k = 0; k < colsA; k++) //строка первой 
            {
                result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return result;
}


/* 60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента. */
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetThirdArray(int x, int y, int z, int minValue, int maxValue) //создание трехмерного массива
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

void PrintArrayThird(int[,,] inArray) //Отображение трехмерного массива
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

/* 62. Заполните спирально массив 4 на 4. */

int[,] SpiralArray(int rows, int columns)
{
    int[,] returnSpiral = new int[rows, columns];
    int n = 1;

    while (n > rows * columns)
    {
        
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            returnSpiral[i, j] = n++;
        }
        if
    }
}
}





Console.Clear();
//---------------------------------------------------------------------
Console.WriteLine("-----------------------\nЗадача №54\n");
int[,] array = GetArray(5, 4, 1, 9);            //Задали массив
PrintArray(array);                              //Отобразили
Console.WriteLine();
ArrayStringReduction(array);
PrintArray(array);                              //Отобразили разницу
//---------------------------------------------------------------------
Console.WriteLine("-----------------------\nЗадача №56\n");
MinSummStringInArray(array);
Console.WriteLine();
PrintArray(array);
//---------------------------------------------------------------------
Console.WriteLine("-----------------------\nЗадача №58\n");
int[,] matrix1 = GetArray(3, 2, 1, 10);         //Задали 2 матрицы
int[,] matrix2 = GetArray(2, 3, 1, 10);
PrintArray(matrix1);                            //Отобразили 2 матрицы
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
int[,] matrix = MatrixMultiply(matrix1, matrix2); //Перемножили
PrintArray(matrix);                             //Отобразили итог
//---------------------------------------------------------------------
Console.WriteLine("-----------------------\nЗадача №60\n");
int[,,] arrayThird = GetThirdArray(4, 4, 4, 10, 100); //Трехмерный массив
PrintArrayThird(arrayThird);                          //Отображение трехмерного массива
Console.WriteLine("-----------------------\nЗадача №62\n");

