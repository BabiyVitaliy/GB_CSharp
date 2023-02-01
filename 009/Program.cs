// С клавиатуры вводятся два числа a и b. Найти максимальное из них.
double a,b;
System.Console.Write("Введите 1 число: ");
a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите 2 число: ");
b=Convert.ToDouble(Console.ReadLine());
if (a>b) System.Console.WriteLine($"{a}{" максимальное"}");
else System.Console.WriteLine($"{b}{" максимальное"}");
