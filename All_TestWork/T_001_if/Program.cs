/* Генерируется случайное целое число n в интервале [ 20 – 99 ].
Проверяется, делится ли оно на введенное с клавиатуры целое число d
(используйте тернарный оператор). */

Random rnd = new Random();
int rand = rnd.Next(19, 100);
int num = int.Parse(Console.ReadLine());

string del1 = (rand / num > 0) ? "Делится" : "нет";

Console.WriteLine(rand);
Console.WriteLine(del1);
Console.WriteLine(num);