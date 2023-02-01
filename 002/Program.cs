// С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго
double a,b;
a=Convert.ToDouble(Console.ReadLine());
b=Convert.ToDouble(Console.ReadLine());
if (a*a==b)
System.Console.WriteLine($"{b} {" является квадратом "} {a}");
if  (b*b==a)
System.Console.WriteLine(a + " является квадратом " + b);

