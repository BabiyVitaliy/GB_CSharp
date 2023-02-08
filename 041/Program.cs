// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
Random var = new Random();
int[] nums = new int[8];
for (int i = 0; i < 7; i++)
{
    if (var.Next(0, 10) < 6) nums[i] = 0;
    else nums[i] = 1;
    System.Console.Write($"{nums[i]} ");
}
