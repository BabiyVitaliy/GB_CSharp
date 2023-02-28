//  Задайте две матрицы. Напишите программу с подпрограммой MultiMatrix, которая будет находить произведение двух матриц. 
// а) простым поэлементным перемножением


System.Console.Write("Введите размер матриц (строк): ");
int CountRows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите размер матриц (столбцов): ");
int CountColumns = Convert.ToInt32(Console.ReadLine());
int[,] userMatrixOne = new int[CountColumns, CountRows];
int[,] userMatrixTwo = new int[CountColumns, CountRows];
initializationMassive(userMatrixOne);
initializationMassive(userMatrixTwo);
MassivOutPut(userMatrixOne);
MassivOutPut(userMatrixTwo);
int [,] userMatrixResult = massivPower(userMatrixOne,userMatrixTwo);
MassivOutPut(userMatrixResult);


int[,] massivPower(int[,] ArrOne, int[,] ArrTwo)
{
 int[,] ArrResult = new int [ArrOne.GetLength(1),ArrOne.GetLength(0)];
 for (int i = 0; i < ArrOne.GetLength(1); i++)
    {
        for (int j = 0; j < ArrOne.GetLength(0); j++)
        {
            ArrResult[i, j] = ArrOne[i, j]*ArrTwo[i, j];
        }
    }
    return ArrResult;
}


void initializationMassive(int[,] Arrow)
{
    Random var = new Random();
    for (int i = 0; i < Arrow.GetLength(1); i++)
    {
        for (int j = 0; j < Arrow.GetLength(0); j++)
        {
            Arrow[i, j] = var.Next(1, 10);
        }
    }
}

void MassivOutPut(int[,] Arrow)
{
    for (int i = 0; i < Arrow.GetLength(1); i++)
    {
        for (int j = 0; j < Arrow.GetLength(0); j++)
        {
            System.Console.Write($"{Arrow[i, j],4}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}