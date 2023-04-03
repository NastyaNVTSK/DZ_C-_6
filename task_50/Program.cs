Console.WriteLine("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[rows, cols];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 50);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

(bool Success, int Row, int Column) SearchInArray(int[,] array, int what) 
{
    bool result = false;
    int row = 0;
    int column = 0;

    for(var i = 0; i < array.GetLength(0); i++) {
        for(var j = 0; j < array.GetLength(1); j++) {
            var element = array[i, j];

            if(element == what) {
                row = (i + 1);      
                column = (j + 1);   
                result = true;

                break;
            }
        }
    }

    return (result, row, column);
}

FillArray(num);
PrintArray(num);
Console.WriteLine("Введите число для поиска: ");
int predicate = Convert.ToInt32(Console.ReadLine());

var result = SearchInArray(num, predicate);

if(!result.Success) {
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Указанное число не найдено в массиве...");
}
else {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Число: {predicate} найдено, его позиция - row ({result.Row}), column ({result.Column})");
}

Console.ResetColor();













