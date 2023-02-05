// Найти сумму чисел от 1 до А
System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = summ (a);
System.Console.WriteLine($"{"Сумма чисел от 1 до "}{a}{" = "}{b}");

int summ (int chislo)
{
    int now = 0;
    while (chislo>0);
    {
        now += a;
        a--;
    }
    
    return now;
}