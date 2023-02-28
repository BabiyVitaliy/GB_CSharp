// 098 Показать треугольник Паскаля
int CountRows = 0;
while (CountRows < 3)
{
    System.Console.Write("Количество строк треугольника Паскаля (больше 3): ");
    CountRows = Convert.ToInt32(Console.ReadLine());
}
GeneratePascalTriangle(CountRows);
void GeneratePascalTriangle(int n)
{

    int[] _previous = new int[n];
    int[] _current = new int[n];
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            if (j == 0 || j == i)
                _current[j] = 1;
            else
                _current[j] = _previous[j-1] + _previous[j];
            Console.Write(_current[j] + " ");
        }
        Console.Write(Environment.NewLine);
        _current.CopyTo(_previous, 0);
    }
}
