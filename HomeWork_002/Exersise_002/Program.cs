/*
Задача 13: Напишите программу, которая 
выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


Console.Clear();

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string rin = Convert.ToString(num);
int reng = Convert.ToInt32(rin.Length);
double pow = Math.Pow(10, (reng - 2));
double pow2 = Math.Pow(10, (reng - 3));

if (num / 100 != 0)
{
    int num_2 = Convert.ToInt32((num % pow) / (10 * pow2));
    Console.WriteLine(num_2);
}

else
{
    Console.WriteLine("Хуйня");
}


// if (num > 99)
// {
//     int num_2 = (num % (num2*));
//     Console.WriteLine(num_2);
// }
// else
// {
//     Console.WriteLine("Вы не ввели третью цифру ало");
// }