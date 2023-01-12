/* 
    1. Решаем через строку или масив
но делаем через целые числа 
    2. 
    3. массив
*/

// /* 
// Задача 28: Напишите программу, которая принимает на вход 
// число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// */

// Console.Write("Введите число ");
// int num = int.Parse(Console.ReadLine());

// void Mult (int N)
// {
//     int sum = 1;
//     for (int i = 1; i <= Math.Abs(N); i++) sum*= i;
//     Console.Write($"Произведение чисел равно {sum}");
// }

// Mult(num);

/* 
Задача 26: Напишите программу, которая принимает на вход число 
и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
 */

// Console.Write("Введите число ");
// int num = int.Parse(Console.ReadLine());

// void NumNum(int num)
// {
//     int chase = 0;
//     while (num != 0)
//     {
//         num = num / 10;
//         chase += 1;
//     }
//     Console.Write($"Колличество символов в числе {chase}");
// }

// NumNum(num);



/* 
Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
 */

Console.Write("Сколько значений в массиве? ");
int[] arr = new int[int.Parse(Console.ReadLine())];

void ArrTrueFalse(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write(arr[i]);
    }
}

ArrTrueFalse(arr);

//альтернатива 
int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}


//1 возведение в степень через for 
//2 изи 
//3 
