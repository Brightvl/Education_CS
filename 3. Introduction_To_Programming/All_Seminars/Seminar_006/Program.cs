
//Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите первое число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int number3 = Convert.ToInt32(Console.ReadLine());
// if (number < number2 + number3)
// {
//     if (number2 < number + number3)
//     {
//         if (number3 < number2 + number)
//         {
//             Console.WriteLine("Да, такой треугольник может существовать");
//         }
//         else
//         {
//             Console.WriteLine("Нет, такой треугольник не может существовать");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Нет, такой треугольник не может существовать");
//     }
// }
// else
// {
//     Console.WriteLine("Нет, такой треугольник не может существовать");
// }

/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */


// Console.Clear();

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int N = Convert.ToInt32(Console.ReadLine());
// int[] Array = CreateRandomArray(Convert.ToInt32(Math.Log2(N)) + 1, 0, 1);
// int i = 0;
// while (N > 0)
// {
//     Array[Array.Length - i - 1] = N % 2;
//     N = N / 2;
//     i++;
// }
// ShowArray(Array);


// void DecimalBinary(int numb)
// {
//     string residue = string.Empty;
//     while (numb > 0)
//     {
//         residue = Convert.ToString(numb % 2) + residue;
//         numb /= 2;
//         Console.WriteLine(numb);
//     }
//     Console.WriteLine(residue);
// }

// DecimalBinary(14);


/*
 * Console.WriteLine("Введите число");
int number_10 = int.Parse(Console.ReadLine());  //10
int i = number_10;                              
string number_02 = "";                          
while (i > 0)
{
    number_02 = i % 2 + number_02;  //остаток от деления        
    i = i / 2;                      //деление самого числа       
}
Console.WriteLine(number_02);
//10 = 2+2+2+2+2(0)    (0)  ^
//5 = 2+2+(1)          (1)  |    
//2 = 2(0)             (0)  |
//1 = 0(1)             (1)  |
*/







/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int number1 = 0;
// int number2 = 1;
// int number3 = 0;
// int j = 0;
// Console.WriteLine(number1);
// Console.WriteLine(number2);
// while (j < number)
// {
//     number3 = number1 + number2;
//     Console.WriteLine(number3);
//     number1 = number2;
//     number2 = number3;
//     j++;
// }

// int[] Fib = new int[size];
// Fib[0] = 0;
// Fib[1] = 1;
// for (int i = 2; i < size; i++)
// {
//     Fib[i] = Fib[i - 2] + Fib[i - 1];
// }



// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 2)
// {
//     Console.WriteLine("Введите число больше 2");
// }
// else
// {
//     int number1 = 0;
//     int number2 = 1;
//     int number3 = 0;
//     Console.WriteLine(number1);
//     Console.WriteLine(number2);
//     for (int j = 0; j < number; j++)
//     {
//         number3 = number1 + number2;
//         Console.WriteLine(number3);
//         number1 = number2;
//         number2 = number3;
//     }
// }






/* Задача 45: Напишите программу, которая будет создавать
 копию заданного массива с помощью поэлементного копирования.
 */

//  int[] array = GetArray(10, 0, 10);
// WriteLine(String.Join(" ", array));

// int[] copyArray=CopyArray(array);
// WriteLine(String.Join(" ", copyArray));


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// int[] CopyArray(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[i];

//     }
//     return result;
// }


