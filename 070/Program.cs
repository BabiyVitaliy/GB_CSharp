// 70. Показать натуральные числа от 1 до N, N задано
int N = 20, i=1;

RecOutput(i,N);
void RecOutput(int i, int N)
{
    System.Console.Write($"{i,4}");
    if (i<N) RecOutput(i+1,N);
}