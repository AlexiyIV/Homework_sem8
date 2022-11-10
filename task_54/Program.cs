int InputData(string message)
{
    Console.Write(message);
    int d = int.Parse(Console.ReadLine());
    return d;
}

bool IsValidSizeArray(int rows, int colums)
{
    return (rows > 0 && colums > 0);
}

int[,] FillArray(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine("sumRow" + (i + 1) + "=" + sumRow);
    }
}

int IndexRowMinSum(int[,] array)
{
    int sumRow = 0;
    int minSumRow = 0;
    int indexMinSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSumRow += array[0,j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i,j];
        }
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            indexMinSum = i;
        }
    }
    return indexMinSum;
}

int rows = InputData("Введите количество строк массива ");
int colums = InputData("Введдите количество столбцов массива ");
int min = InputData("Введите минимальное значение элемента массива ");
int max = InputData("Введите максимальное значение элемента массива ");
if (IsValidSizeArray(rows, colums))
{
    int[,] array = FillArray(rows, colums, min, max);
    PrintArray(array);
    int rowMinSum = IndexRowMinSum(array);
    Console.WriteLine("Минимальная сумма элементов в строке " + (rowMinSum+1));
}
else Console.WriteLine("Ошибка ввода");