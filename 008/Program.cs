// Вывести на экран числа от -N до N
int a;
System.Console.Write("Введите число: ");
a=Convert.ToInt32(Console.ReadLine());
if (a<0) a = a * -1; 
int b = a * -1;
while (b<a)
{
    System.Console.WriteLine(b);
    b++;
}
