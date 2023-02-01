// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b 
double a,b;
System.Console.Write("Введите 1 число: ");
a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите 2 число: ");
b=Convert.ToDouble(Console.ReadLine());

if (b%a==0) System.Console.WriteLine($"{a}{" кратно "}{b}");
else System.Console.WriteLine($"{"Остаток от деления "}{a}{" на "}{b}{" равен: "}{a%b}");

