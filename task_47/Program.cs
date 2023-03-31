    Random rnd = new Random();
    void FillArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            { 
                array[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); 
            }
        }
    }

void PrintArray(double[,] array)
{
    for (int i =0; i<array.GetLength(0);i++)
        {
        for (int j =0; j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],4}\t") ;
        Console.WriteLine();
        }       
}


    Console.WriteLine("Введите количество строк:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    FillArray(array);
    Console.WriteLine();
    PrintArray(array);