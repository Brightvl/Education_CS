//Рекурсии

/* Задача 64: Задайте значение N. Напишите 
программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с 
помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

void PrintNumbers(int start)
{
    if (start < 1) return; // пошел нахер введи больше 0
    Console.Write($"{start} ");
    if (start == 1) return;
    PrintNumbers(start - 1);
}

PrintNumbers(N);


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите M");
int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());

int SumOfInterval(int firstNum, int secondNum)
{

    int sum = 0;
    if (firstNum == secondNum) return secondNum;
    sum = firstNum + SumOfInterval(firstNum + 1, secondNum);
    Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
    return sum;
}

Console.WriteLine(SumOfInterval(M, N));

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите M");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

Console.WriteLine(Ackermann(m, n));