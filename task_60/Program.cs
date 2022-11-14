int InputData(string message)
{
    Console.Write(message);
    int d = int.Parse(Console.ReadLine());
    return d;
}

bool IsValidSizeArray(int module, int rows, int colums)
{
    return (module > 0 && rows > 0 && colums > 0);
}

int[,,] FillArray(int module, int rows, int colums, int min, int max)
{
    int[,,] array = new int[module, rows, colums];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(min, max);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + "; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int moduleA = InputData("Введите количество модулей массива A ");
int rowsA = InputData("Введите количество строк массива A ");
int columsA = InputData("Введдите количество столбцов массива A ");
int min = InputData("Введите минимальное значение элемента массива ");
int max = InputData("Введите максимальное значение элемента массива ");
if (IsValidSizeArray(moduleA, rowsA, columsA))
{
    int[,,] array = FillArray(moduleA, rowsA, columsA, min, max);
    PrintArray(array);
}
else Console.WriteLine("Ошибка");