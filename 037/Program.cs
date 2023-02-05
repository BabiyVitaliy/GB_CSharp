//Глупая задача. Показать кубы чисел, заканчивающихся на четную цифру

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

for (int i =1; i<a+1; i++)
{ 
    if (Yes(i)) System.Console.WriteLine($"{"Куб числа "}{i}{" = "}{PowerUp(i)}");
}


double PowerUp(int a)
{
    return Math.Pow(a, 3);
}


bool Yes(int a)
{
    if (a % 2 == 0)
        return true;
    else
        return false;
}



