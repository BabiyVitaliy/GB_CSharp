// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами

System.Console.Write("Введите длину массива: ");
int ArrawDlina = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите ширину массива: ");
int ArrawShirina = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальную границу значения элемента массива: ");
int ArrawElementMax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите минимальную границу значения элемента массива: ");
int ArrawElementMin = Convert.ToInt32(Console.ReadLine());

int[,] userArrow = InitialRandomArraw(ArrawDlina, ArrawShirina, ArrawElementMin, ArrawElementMax);
OutputArraw(userArrow);



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