// формируем прямоугольный массив чисел из двух строк
int[,] ar = { { 11, 12, 13, 14, 15 }, { 21, 22, 23, 24, 25 } };
// с помощью foreach все элементы выводятся в одну строку
foreach (int x in ar) Console.Write("{0,4}", x);
Console.WriteLine();
// выводим числа построчно (в форме таблицы)
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 5; j++) Console.Write("{0,4}", ar[i, j]); // j-я строка
    Console.WriteLine();   // переход на следующую строку
}
Console.ReadKey();