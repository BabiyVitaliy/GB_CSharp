// 71. Показать натуральные числа от N до 1, N задано

int N = 20, i=1;
RecOutput(i,N);
void RecOutput(int i, int N)
{
    System.Console.Write($"{N,4}");
    if (i<N) RecOutput(i,--N);
}
