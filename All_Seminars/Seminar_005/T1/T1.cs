//5 Семинар одномерные массивы



/* Задача 31: Задайте массив из 12 элементов, заполненный 
случайными числами из промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна -20.
 */

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] Array1 = CreateRandomArray(12, -9, 9);
ShowArray(Array1);

int positive = 0;
int negative = 0;

for (int i = 0; i < Array1.Length; i++)
{
    if (Array1[i] > 0)positive += Array1[i];
    elsenegative += Array1[i];
}

Console.WriteLine($"Сумма позитивных = {positive}\n+Сумма негативных = {negative}");