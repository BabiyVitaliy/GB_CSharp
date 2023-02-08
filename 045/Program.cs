// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
System.Console.Write("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Random var = new Random();
int[] nums = new int[a];
int chet = 0, nechet = 0;

podschet(nums, ref chet, ref nechet);

void podschet(int[] nums, ref int chet, ref int nechet)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = var.Next(100, 999);
        if (nums[i] % 2 == 0) chet++;
        else nechet++;

        System.Console.Write($"{nums[i]} ");

    }
}
System.Console.Write($"Чётных чисел {chet} ");
System.Console.Write($"Нечётных чисел {nechet} ");

