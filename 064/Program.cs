//064 В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.


System.Console.Write("Введите длину массива: ");
int ArrowDlina = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите ширину массива: ");
int ArrowShirina = Convert.ToInt32(Console.ReadLine());


int[,] userArrow = InitialRandomArraw(ArrowDlina, ArrowShirina, 1, 100);
OutputArraw(userArrow);
System.Console.WriteLine();
userArrow = SwapChetnoePower(userArrow);
OutputArraw(userArrow);

int[,] SwapChetnoePower(int[,] Arrow)
{
    for (int i = 0; i < Arrow.GetLength(0); i=i+2)
        for (int j = 0; j < Arrow.GetLength(1); j=j+2)
            Arrow[i,j] *= Arrow[i,j]; // Я ЗНАЮ ЧТО МОЖНО БЫЛО ПРОВЕРИТЬ ЯВЛЯЕТСЯ ЛИ ИНДЕКС ЧЁТНЫМ И ТОГДА ВОЗВОДИТЬ В КВАДРАТ... 
                                      // НО ЗАЧЕМ НАМ ВООБЩЕ ПРОВЕРЯТЬ ИНДЕКСЫ, ЕСЛИ НАМ НУЖНЫ ТОЛЬКО ЧЁТНЫЕ НУ И 0 ВРОДЕ КАК ЧЁТНОЕ (ЗАГУГЛИЛ)
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