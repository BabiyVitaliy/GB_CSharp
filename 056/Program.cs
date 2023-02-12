// С Написать программу копирования массива

int[] OriginalMassiv = { 1, 3, 5, 6, 7, 8, 5, 5, 5, 4 };
int[] CopyMassiv = new int[OriginalMassiv.Length];
System.Console.Write("Исходный массив: ");
MassivOutPut(OriginalMassiv);
System.Console.WriteLine();
CopyrireMassiv(OriginalMassiv, CopyMassiv);
System.Console.Write("Копия массива: ");
MassivOutPut(CopyMassiv);

void CopyrireMassiv(int[] OriginalArrow, int[] CopyArrow)
{
   for (int i = 0; i < OriginalArrow.Length; i++)
   {
        CopyArrow[i]=OriginalArrow[i];
   }
}

void MassivOutPut(int[] Arrow)
{
    for (int i = 0; i < Arrow.Length; i++)
    {
        System.Console.Write($"{Arrow[i]} ");
    }
    System.Console.WriteLine();
}


