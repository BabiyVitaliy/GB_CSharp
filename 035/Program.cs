// Подсчитать сумму цифр в числе. Сделать подпрограмму.

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{"Сумма цифер числа "}{a}{" - "}{SummCiferChisla(a)}");
int SummCiferChisla (int a)
{
    if (a < 10) 
    {
        return a%10;
    }
    else
    {
        return a%10 + SummCiferChisla(a/10);
    }
    
}