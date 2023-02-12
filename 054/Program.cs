// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1
int a=0;

while (a<3)
{
    System.Console.Write("Введите введите количество чисел ряда Фибоначчи (больше 2): ");
    a=Convert.ToInt32(Console.ReadLine());
}

int[] userArrow = new int[a];
Fibonachchi(userArrow);
MassivOutPut(userArrow);


void Fibonachchi(int[] Arrow)
{
    Arrow[0]=0;Arrow[1]=1;
    for (int i = 2; i < Arrow.Length; i++)
    {
        Arrow[i]=Arrow[i-2]+Arrow[i-1];
    }
}


void MassivOutPut (int[] Arrow)
{
    for (int i = 0; i < Arrow.Length; i++)
    {
        System.Console.Write($"{Arrow[i]} ");
    }
    System.Console.WriteLine();
}


