// Задан массив a из N элементов. 
// Заполнить массив случайными числами от 1 до 10. 
// Создайте массив, который является произведением пар чисел в одномерном массиве a. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д

System.Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Random var = new Random();
int[] a = new int[N];
int[] b = new int[N / 2];
podschet(a);
pair(a, ref b);
void podschet(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = var.Next(1, 10);
        System.Console.Write($"{nums[i]} ");
    }
    System.Console.WriteLine();
}
void pair(int[] nums, ref int[] betta)
{
    for (int i = 0; i < nums.Length / 2; i++)
    {
        betta[i] = nums[i] * nums[nums.Length - i - 1];
        System.Console.WriteLine($"{nums[i]} * {nums[nums.Length - i - 1]} = {betta[i]}");
    }
}

