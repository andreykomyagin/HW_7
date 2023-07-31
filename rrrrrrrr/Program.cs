// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void Task47()
{
    int m = Input("Введите количество строк: ");
    int n = Input("Введите количество столбцов: ");
    double[,] matrix = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = Math.Round(rnd.NextDouble()*10/2, 1); // [0,5)
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}
Task47();
Console.WriteLine();

void Task50()
{
    int m = Input("Введите количество строк: ");
    int n = Input("Введите количество столбцов: ");
    int[,] matrix = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = rnd.Next(1,10); // [0,5)
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int m_find = Input("Введите строку искомого элемента: "); // считаем от 0
    int n_find = Input("Введите столбец искомого элемента: "); // считаем от 0
    if ((m_find < m) && (n_find < n))
    { 
    Console.WriteLine($"{matrix[m_find, n_find]} - это искомый элемент!");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует!");
    }
}
Task50();
Console.WriteLine();

void Task52()
{
    int m = Input("Введите количество строк: ");
    int n = Input("Введите количество столбцов: ");
    int[,] matrix = new int[m,n];
    Random rnd = new Random();
    double sum;
    double[] aver_val = new double [n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = rnd.Next(1,10); // [0,5)
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }


     for (int i = 0; i < n; i++)
    {
        sum = 0;
        for (int j = 0; j < m; j++)
        {
            sum += matrix[j,i];
        }
        aver_val[i] = Math.Round(sum / m, 1);
        Console.WriteLine($"{aver_val[i]} - среднее значение {i}-го стоблца");
    }
}
Task52();