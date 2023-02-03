// По двум заданным числам проверять является ли одно квадратом другого
double a,b;
System.Console.Write("Введите 1 число: ");
a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите 2 число: ");
b=Convert.ToDouble(Console.ReadLine());
if (Math.Sqrt(a)==b || Math.Sqrt(b)==a) System.Console.Write("Одно число является квадратом другого");
else System.Console.Write("Числа не являются квадратом");
