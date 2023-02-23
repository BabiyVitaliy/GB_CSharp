// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
System.Console.Write("Введи строку: ");
string stroka = Console.ReadLine();
System.Console.Write("Введи скомый символ: ");
char simbol = Convert.ToChar(Console.ReadLine());
int k = 0;
foreach (char item in stroka)
if (item == simbol) k++;
System.Console.WriteLine($"в строке {stroka} символ {simbol} встречается {k} раз(а)");

