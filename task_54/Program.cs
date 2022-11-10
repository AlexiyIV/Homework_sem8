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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "; ");
        }
        Console.WriteLine();
    }
}

int[,] SortRowArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k + 1] > array[i, k])
                {
                    temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
    return array;
}

int rows = InputData("Введите количество строк массива ");
int colums = InputData("Введдите количество столбцов массива ");
int min = InputData("Введите минимальное значение элемента массива ");
int max = InputData("Введите максимальное значение элемента массива ");
if (IsValidSizeArray(rows, colums))
{
    int[,] Array = FillArray(rows, colums, min, max);
    PrintArray(Array);
    Console.WriteLine();
    Console.WriteLine();
    Array = SortRowArray(Array);
    PrintArray(Array);
}
else Console.WriteLine("Ошибка");