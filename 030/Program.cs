// Вывести на экран таблицу квадратов чисел от 1 до N

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<a; i++)
{
    System.Console.WriteLine($"{i}{"^3="}{Math.Pow(i,3)}");
}
