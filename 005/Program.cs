// С клавиатуры вводятся три числа. Найти максимальное из трех чисел
double a,b,c;
System.Console.Write("Введите 1 число: ");
a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите 2 число: ");
b=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите 3 число: ");
c=Convert.ToDouble(Console.ReadLine());
if (a>b)
{
    if(a>c) System.Console.WriteLine($"{a}{" максимальное"}");
    
}
else
{
    if (b>c) System.Console.WriteLine($"{b}{" максимальное"}");
    else System.Console.WriteLine($"{c}{" максимальное"}");
};

