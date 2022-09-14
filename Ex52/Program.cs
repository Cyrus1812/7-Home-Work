Console.WriteLine("Введите количество столбцов в массиве: ");
bool line = int.TryParse(Console.ReadLine(), out int lineinmassive);
Console.WriteLine("Введите количество строк в массиве: ");
bool column = int.TryParse(Console.ReadLine(), out int columninmassive);

if (!line || !column || columninmassive<1 || lineinmassive<1)
{
    Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}

int[,] resultmassive = new int[lineinmassive,columninmassive];
int[,] printmassive = New2xMassive(resultmassive);
PrintMassive(printmassive);

int[,] New2xMassive(int[,]table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(1,10);
        }
    }
    return table;
}

void PrintMassive(int[,]table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"  {table[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,]table)
{
      Console.WriteLine("Среднее арифметическое каждого столбца равно: ");
    double[] mean = new double[columninmassive];
    for (int i = 0; i < table.GetLength(1); i++)
    {
        for (int j = 0; j < table.GetLength(0); j++)
        {
            if(i <= lineinmassive)
            {
                mean[i] += table[j,i];
            }
        }
        Console.Write($"{(mean[i]/lineinmassive)}   ");
    }
}
ArithmeticMean(resultmassive);
