//068 Написать программу, которая обменивает элементы первой строки и последней строки


System.Console.Write("Введите длину массива: ");
int ArrowDlina = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите ширину массива: ");
int ArrowShirina = Convert.ToInt32(Console.ReadLine());


int[,] userArrow = InitialRandomArraw(ArrowDlina, ArrowShirina, 1, 100);
OutputArraw(userArrow);
System.Console.WriteLine();
userArrow = SwapFirstAndLastLine(userArrow);
OutputArraw(userArrow);

int[,] SwapFirstAndLastLine(int[,] Arrow)
{
    int temp;
    for (int i = 0; i < Arrow.GetLength(1); i++)
    {
        temp = Arrow[0, i];
        Arrow[0, i] = Arrow[Arrow.GetLength(0) - 1, i];
        Arrow[Arrow.GetLength(0) - 1, i] = temp;
    }
    return Arrow;
}

int[,] InitialRandomArraw(int m, int n, int min, int max)
{
    int[,] Arr = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < Arr.GetLength(0); i++)
        for (int j = 0; j < Arr.GetLength(1); j++)
            Arr[i, j] = random.Next(min, max + 1);
    return Arr;
}

void OutputArraw(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],6}");
        System.Console.WriteLine();
    }
}