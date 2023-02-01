System.Console.Write("Введи число от 1 до 7: ");      
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{"Введённое число "}{a}{" это: "}");
switch (a)
{
case 1: System.Console.Write("Понедельник");break;
case 2: System.Console.Write("Вторник");break;
case 3: System.Console.Write("Среда");break;
case 4: System.Console.Write("Четверг");break;
case 5: System.Console.Write("Пятница");break;
case 6: System.Console.Write("Суббота");break;
case 7: System.Console.Write("Воскресенье");break;
default: System.Console.WriteLine("Вы ввели число не соответствующее дню недели");break;
}

