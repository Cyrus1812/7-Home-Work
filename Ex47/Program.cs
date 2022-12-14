Console.WriteLine("Введите количество столбцов в массиве: ");
bool line = int.TryParse(Console.ReadLine(), out int lineinmassive);
Console.WriteLine("Введите количество строк в массиве: ");
bool column = int.TryParse(Console.ReadLine(), out int columninmassive);

if (!line || !column || columninmassive<1 || lineinmassive<1)
{
    Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
}

double[,] resultmassive = new double[lineinmassive,columninmassive];
PrintMassive(New2xMassive(resultmassive));

double[,] New2xMassive(double[,]table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(-10,100)/10.0;
        }
    }
    return table;
}

void PrintMassive(double[,]table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($" |{table[i, j]}| ");
        }
        Console.WriteLine();
    }
}