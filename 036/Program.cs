// Подсчитать сумму цифр в числе. Сделать подпрограмму.

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{"Факториал числа "}{a}{" - "}{Fact(a)}");
int Fact (int a)
{
    if (a == 1 ) 
    {
        return 1;
    }
    else
    {
        return a * Fact(a-1);
    }
    
}