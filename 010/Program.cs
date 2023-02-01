// Вывести на экран последнюю цифру целого числа введенного с клавиатуры
int a;
System.Console.Write("Введите 1 число: ");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{"Последняя цифра числа "}{a}{": "}{a%10}");