// Вывести на экран кубы чисел от 1 до N

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

PowerUp (a);

void PowerUp(int n)
{
    for (int i = 1; i < n; i++)
    {
        System.Console.WriteLine($"{i}{"^3="}{Math.Pow(i, 3)}");
    }
}

