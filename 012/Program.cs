// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа
int a=0;

while (a<10||a>99)
{
    System.Console.Write("Введите число в диапазоне от 10 до 99 :");
    a=Convert.ToInt32(Console.ReadLine());
}
if (a%10>a/10%10) 
{
    System.Console.WriteLine($"{a/10%10}{"<"}{a%10}");
    System.Console.WriteLine($"{"Наибольшая цифра: "}{a%10}");
}
else 
{
    System.Console.WriteLine($"{a/10%10}{">"}{a%10}");
    System.Console.WriteLine($"{"Наибольшая цифра: "}{a/10%10}");
}

