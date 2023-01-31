/* 3. Вычисляется и выводится в таблицу с шагом 10 км стоимость поездки
на автомобиле в зависимости от расстояния S (10 – 90 км). С клавиатуры */

Console.Write("Введите расход бензина на 100 км: ");
if (double.TryParse(Console.ReadLine(), out double b))
{
  Console.Write("Введите цену бензина за 1 литр: ");
  if (double.TryParse(Console.ReadLine(), out double c))
    {
      for(double i=10;i<100;i+=10)
        {
          Console.WriteLine("Стоимость поездки на {0} км составит {1}", i, b*i*c/100);
        }
    }
  else 
  {
    Console.Write("Вы ввели не корректную цену бензина!");
  }
}
else 
{
  Console.Write("Вы ввели не корректный расход топлива!");
}