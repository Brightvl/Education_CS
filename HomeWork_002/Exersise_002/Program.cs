/*
Задача 13: Напишите программу, которая 
выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.Clear();
Console.WriteLine("Ввеите число");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("Вы не ввели 3-х значное число");
}
else
{
    while (num > 1000)
    {
        num = num / 10;
    }
    Console.WriteLine($"Третья цифра в числе = {num % 10}");
}
//до тех пор пока число больше 1000 дели на 10!

// Через длину
// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2)
// {
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else 
// {
//   Console.WriteLine("-> третьей цифры нет");
// }