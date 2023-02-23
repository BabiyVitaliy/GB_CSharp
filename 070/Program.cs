// 70. Показать натуральные числа от 1 до N, N задано
int N = 0, i=1;
while (N < 2)
{
    System.Console.Write("Введите число больше 1: ");
    N = Convert.ToInt32(Console.ReadLine());
}
RecOutput(i,N);


void RecOutput(int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i<N) RecOutput(i+1,N);
}