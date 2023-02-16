// 061 Показать двумерный массив размером m×n заполненный вещественными случайными числами

System.Console.Write("Введите длину массива: ");
int ArrawDlina = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите ширину массива: ");
int ArrawShirina = Convert.ToInt32(Console.ReadLine());

double[,] userArrow = InitialRandomDoubleArraw(ArrawDlina, ArrawShirina);
OutputArraw(userArrow);



double[,] InitialRandomDoubleArraw(int m, int n)
{
    double[,] Arr = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < Arr.GetLength(0); i++)
        for (int j = 0; j < Arr.GetLength(1); j++)
            Arr[i, j] = random.NextDouble()*10;
    return Arr;
}

void OutputArraw(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],6:F2}");
        System.Console.WriteLine();
    }
}

