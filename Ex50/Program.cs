void SearchIndex(int[,] table)
{
    Console.WriteLine("Введите искомое число: ");
    bool line = int.TryParse(Console.ReadLine(), out int a);
    if (!line)
    {
        Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i, j] == a)
            {
                Console.WriteLine($"Число {a} в двумерном массиве находится под индексом ({i};{j})");
            }
        }
    }
}

int[,] NewDoubleMassive(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 10);
        }
    }
    return table;
}

void PrintMassive(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"|{table[i, j]}|");
        }
        Console.WriteLine();
    }
}
int[,] result = new int[5, 5];
int[,] res = NewDoubleMassive(result);
SearchIndex(res);
PrintMassive(res);



