// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Random var = new Random();
int[] nums = new int[123];

podschet(nums);

void podschet(int[] nums)
{
    int count=0;
    for (int i = 0; i < 123; i++)
    {
        nums[i] = var.Next(0, 999);
        System.Console.Write($"{nums[i]} ");
        if (nums[i] > 9 && nums[i] < 100) count++;
    }
    System.Console.WriteLine();
    System.Console.Write($"В массиве {count} элементов между 10 и 99");
}


