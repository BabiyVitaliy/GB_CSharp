// Удалить вторую цифру целого числа введенного с клавиатуры.
int a=0;
while (a<10)
{
    System.Console.Write("Введите число больше 10:");
    a=Convert.ToInt32(Console.ReadLine());
}
if (a<100) System.Console.WriteLine($"{"Число: "}{a}{" без второй цифры: "}{a%10}");
else System.Console.WriteLine($"{"Число: "}{a}{" без второй цифры: "}{a/100}{a%10}");
