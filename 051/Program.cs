// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
System.Console.Write("Введите размер массива: ");
int CountElementMassiv = Convert.ToInt32(Console.ReadLine());
int[] userArrow = new int[CountElementMassiv];
initializationMassive(userArrow);
System.Console.Write($"В массиве: ");
MassivOutPut(userArrow);
System.Console.WriteLine($"{countMoreNull(userArrow)} элементов > 0");



int countMoreNull(int[] Arrow)
{
    int count = 0;
    for (int i = 0; i < Arrow.Length; i++)
    {
      if (Arrow[i] > 0) count++;
    }
    return count;
}

void initializationMassive (int[] Arrow)
{
    Random var = new Random();
    for (int i = 0; i < Arrow.Length; i++)
    {
        Arrow[i] = var.Next(-10, 10);
        System.Console.Write($"{Arrow[i]} ");
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Массив заполнен..." );
}

void MassivOutPut (int[] Arrow)
{
    for (int i = 0; i < Arrow.Length; i++)
    {
        System.Console.Write($"{Arrow[i]} ");
    }
    System.Console.WriteLine();
}
