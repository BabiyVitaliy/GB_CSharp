// Написать программу вычисления значения функции y = sin(a). (Класс Math)
double a;
System.Console.Write("Введите число: ");
a=Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{"Sin "}{a}{" = "}{Math.Sin(a)}");
