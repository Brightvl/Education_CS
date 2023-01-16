/*  
Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
 */

Console.WriteLine("Введите число");
string num = Console.ReadLine();
int sum = 0;

int GetSumNums(int number)
{
    for (int i = 0; i < num.Length; i++)
    {
        sum = sum + Convert.ToInt32(Convert.ToString(num[i]));
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}

int GetSumNums1(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}