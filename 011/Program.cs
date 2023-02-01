// Дано число больше 9. Вывести на экран  вторую цифру числа с конца
int a=0;

while (a<10)
{
    System.Console.Write("Введите число больше 9:");
    a=Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine($"{"Вторая цифра числа "}{a}{": "}{a/10%10}");
