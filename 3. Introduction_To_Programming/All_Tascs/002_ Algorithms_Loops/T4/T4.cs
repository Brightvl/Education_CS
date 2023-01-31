/* В интервале [0, 2 c] с шагом 0.1с вычисляются координаты y = V0t – gt^2/2
и скорости V = V0 – gt мячика, брошеного вертикально вверх с начальной
скоростью V0 (V0 вводится с клавиатуры, цикл for). */

Console.Clear();
Console.Write("Введите скорость броска = ");
double V0 = double.Parse(Console.ReadLine());
double g = 9.8, y = 0, t = 0, V = 0;
int x = 0, y1 = 0;

for (double i = 0; i < 2; i += 0.1)
{
    y = V0 * t - g * t * t / 2;
    V = V0 - g * t;
    t += 0.1;
    if (y1 == 10) { x += 30; y1 = 1; }
    else y1 += 1;
    Console.SetCursorPosition(x, y1);
    Console.WriteLine($"| h = {Math.Round(y, 1)}м");
    Console.SetCursorPosition(x + 12, y1);
    Console.WriteLine($"- Vм = {Math.Round(V, 1)}");
    Console.SetCursorPosition(x + 24, y1);
    Console.WriteLine("|");
}
// код выполнен с отображением высоты и скорости мячика каждые 0.1 с времени
// но в обратном направлении

