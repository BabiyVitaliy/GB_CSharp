// Определить количество цифр в числе. Сделать подпрограмму.
System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{"В числе "}{a}{" - "}{HowMany(a)}{" цифер"}");




int HowMany (int a)
{
    if (a < 10) 
    {
        return 1;
    }
    else
    {
        return 1 + HowMany(a/10);
    }
    
}