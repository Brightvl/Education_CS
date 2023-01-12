/* Напишите программу, которая принимает 
на вход пятизначное число и проверяет, является ли 
оно палиндромом.

14212 -> нет
23432 -> да
12821 -> да */


Console.Clear();

Console.Write("Для проверки палиндрома, введите любое число или слово");
string num = Console.ReadLine();
int numTxt = num.Length;

for (int i = 1; i < numTxt; i++)
{
    if (num[i - 1] != num[numTxt - (i)])
    {
        Console.WriteLine("не палиндром!");
        break;
    }
    if (i == numTxt-1)
    {
        Console.WriteLine("палиндром!");
        break;
    }
}

