/* Проверяется соответствие веса и роста (ввод рост и вес; вывод одного
из сообщений "Норма", "Нужно похудеть", "Нужно поправиться".
Нормальный вес (в кг) = (рост (в см) – 100) ± 10%. (оператор if ) */

Console.WriteLine("Write down your weight");
int weight = int.Parse(Console.ReadLine());

Console.WriteLine("Write down your height");
int height = int.Parse(Console.ReadLine());

int normal_weight = height - 100;

if (weight > normal_weight + 10)
{
    
}