Console.WriteLine("Введите количество столбцов в массиве: ");
bool line = int.TryParse(Console.ReadLine(), out int lineinmassive);
Console.WriteLine("Введите количество строк в массиве: ");
bool column = int.TryParse(Console.ReadLine(), out int columninmassive);

Console.WriteLine("Введите искомое число: ");
bool number = int.TryParse(Console.ReadLine(), out int a);
    if (!line || !column || !number || columninmassive<1 || lineinmassive<1)
    {
        Console.WriteLine("Не верные введённые данные, попробуйте поменять значение.");
    }

void SearchIndex(int[,] table)
{
    int notfound = 0;
    int quanity = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i, j] == a)
            {
                Console.WriteLine($"Число {a} в двумерном массиве находится под индексом ({i};{j})");
            }
            else
            {
                notfound ++;
            }
            quanity = table.GetLength(1) * table.GetLength(0);
        }
    }
    if (notfound == quanity)
    {
        Console.WriteLine("Число не найдено");
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
int[,] doublemassive = new int[columninmassive, lineinmassive];
int[,] resultmassive = NewDoubleMassive(doublemassive);
PrintMassive(resultmassive);
SearchIndex(resultmassive);