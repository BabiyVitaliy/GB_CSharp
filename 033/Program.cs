// Возведите число А в натуральную степень B используя цикл

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{a}{" в степени "}{b}{" = "}{pow(a,b)}");
int pow(int a, int b)
{
    int temp = 1;
    for (int i = 0; i < b; i++)
    {
        temp *= a;
    }
    return temp;
}