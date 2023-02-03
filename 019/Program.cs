// Программа проверяет пятизначное число на палиндромом. Например: 12321
int a;
do
{
    System.Console.Write("Введите число: ");
    a=Convert.ToInt32(Console.ReadLine());
} while(a < 10000 || a > 99999);
if (a/10000==a%10 && a/1000%10==a/10%10) System.Console.WriteLine($"{"Число: "}{a}{" является полиндромом"}");
else System.Console.WriteLine($"{"Число: "}{a}{" не является полиндромом"}");