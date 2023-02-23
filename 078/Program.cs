// 078. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. Использовать рекурсию
int a = 0;
while (a < 3)
{
    System.Console.Write("Введите введите количество чисел ряда Фибоначчи (больше 2): ");
    a = Convert.ToInt32(Console.ReadLine());
}

RecRowFibonacci(a-1);

void RecRowFibonacci(int n)
{
    if (n > -1)
    {
        RecRowFibonacci(n - 1);
        System.Console.WriteLine(RecElemFibonacci(n));

    }
    // else return;
}

int RecElemFibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1 || n == 2)
        return 1;

    return RecElemFibonacci(n - 1) + RecElemFibonacci(n - 2);
}
