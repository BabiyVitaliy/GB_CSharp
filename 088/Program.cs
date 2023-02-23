// 88. Заменить все вхождения подстроки w в строке st на строку v. 
// Вывести на экран первоначальную строку и конечную строку

System.Console.Write("Введи строку: ");
string stroka = Console.ReadLine();
System.Console.Write("Что меняем: ");
string textChange = Console.ReadLine();
System.Console.Write("На что меняем: ");
string textSwap = Console.ReadLine();
System.Console.WriteLine($"Оригинальный текст: {stroka}");
System.Console.WriteLine($"Заменённый текст: {stroka.Replace(textChange, textSwap)}");

