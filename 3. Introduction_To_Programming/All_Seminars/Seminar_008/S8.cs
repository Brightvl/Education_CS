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

// Создаем функцию, которая принимает двумерный массив и возвращает частотный словарь элементов
Dictionary<int, int> CreateFrequencyDictionary(int[,] inputArray)
{
    // Создаем новый словарь
    Dictionary<int, int> frequencyDictionary = new Dictionary<int, int>();
    // Перебираем все элементы массива
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            // Получаем текущий элемент
            int currentElement = inputArray[i, j];
            // Если элемент уже есть в словаре, то увеличиваем его счетчик
            if (frequencyDictionary.ContainsKey(currentElement))
            {
                frequencyDictionary[currentElement]++;
            }
            // Иначе добавляем элемент в словарь и задаем счетчик = 1
            else
            {
                frequencyDictionary.Add(currentElement, 1);
            }
        }
    }
    // Возвращаем частотный словарь
    return frequencyDictionary;
}

// Создаем функцию, которая принимает частотный словарь и выводит его в консоль
void PrintFrequencyDictionary(Dictionary<int, int> frequencyDictionary)
{
    // Перебираем все пары ключ-значение в словаре
    foreach (KeyValuePair<int, int> item in frequencyDictionary)
    {
        // Выводим ключ и значение в консоль
        Console.WriteLine("Element: {0}, Frequency: {1}", item.Key, item.Value);
    }
}


// Создаем функцию, которая принимает двумерный массив и возвращает частотный словарь элементов
int[] CreateFrequencyArray(int[,] array)
{
    // Создаем массив для хранения частот элементов
    int[] frequency = new int[(array.GetUpperBound(0) + 1) * (array.GetUpperBound(1) + 1)];
    // Перебираем все элементы массива
    for (int i = 0; i <= array.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= array.GetUpperBound(1); j++)
        {
            // Увеличиваем частоту элемента на 1
            frequency[array[i, j]]++;
        }
    }
    return frequency;
}

// Создаем функцию, которая принимает частотный словарь и выводит его в консоль
void PrintFrequencyArray(int[] frequency) {
    // Перебираем все пары ключ-значение в словаре
    for (int i = 0; i < frequency.Length; i++) {
        if (frequency[i] != 0)
        {
            // Выводим ключ и значение в консоль
            Console.WriteLine("Element: {0}, Frequency: {1}", i, frequency[i]);
        }
    }
}
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

Dictionary<int, int> lol = CreateFrequencyDictionary(newArray);
PrintFrequencyDictionary(lol);
Console.WriteLine("---------");

int[] newArray1 = CreateFrequencyArray(newArray);
PrintFrequencyArray(newArray1);
