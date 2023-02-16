// 062 В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
// Написать отдельную подпрограмму на вход которой подается массив, 
// а на выходе измененный массив.

System.Console.Write("Введите длину массива: ");
int ArrawDlina = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите ширину массива: ");
int ArrawShirina = Convert.ToInt32(Console.ReadLine());


int[,] userArrow = InitialRandomArraw(ArrawDlina, ArrawShirina, 1, 100);
OutputArraw(userArrow);
System.Console.WriteLine();
userArrow = SwapChetnoe(userArrow);
OutputArraw(userArrow);

int[,] SwapChetnoe(int[,] Arrow)
{
    for (int i = 0; i < Arrow.GetLength(0); i++)
        for (int j = 0; j < Arrow.GetLength(1); j++)
            if (Arrow[i,j]%2 == 0) Arrow[i,j] *= -1;
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