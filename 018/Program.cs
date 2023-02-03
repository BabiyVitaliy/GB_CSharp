// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
double a,b;
do
{
    System.Console.Write("Введите 1 число (!=0): ");
    a=Convert.ToDouble(Console.ReadLine());
    System.Console.Write("Введите 2 число (!=0): ");
    b=Convert.ToDouble(Console.ReadLine());
}
while(a==0 || b==0);
if (a>0 && b > 0) System.Console.Write("I четверть");
else if (a< 0 && b > 0) System.Console.Write("II четверть");
else if (a< 0 && b < 0) System.Console.Write("III четверть");
else System.Console.Write("IV четверть");

