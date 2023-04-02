Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
int[] columns_sum = new int[cols];
void FillArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
        for (var j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 30);
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}
void Arith(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            columns_sum[j] += array[i, j];
        }
    }
    foreach (var sum in columns_sum)
    {
        Console.Write($"{sum / rows}       ");
    }
}


FillArray(array);
PrintArray(array);
Console.WriteLine();
Arith(array);



/*int[,] array = new int[3, 6]{
   { 0, 1, 2, 3, 4, 5 },    {312, 132, 3211, 322, 1323, 12313 },
   { 4, 4, 5, 2, 2, 5 }};
int[] middles = new int[3];
for (var i = 0; i < array.GetLength(0); i++)
{
    var sum = 0;
    var size = array.GetLength(1);
    for (var j = 0; j < size; j++)
    {
        sum += array[i, j];
    }
    middles[i] = sum / size;
}
foreach (var middle in middles)
{
    Console.WriteLine(middle);
}*/

