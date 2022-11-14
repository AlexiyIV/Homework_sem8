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

bool IsValidMultliplicationArray(int columsA, int rowsB)
{
    return (columsA == rowsB);
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

int[,] MultiplicationArray(int[,] arrayA, int[,] arrayB)
{
    int[,] MultiArray = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < MultiArray.GetLength(0); i++)
    {
        for (int j = 0; j < MultiArray.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                temp += arrayA[i,k] * arrayB[k,j];
            }
            MultiArray[i,j] = temp; 
        }
    }
    return MultiArray;
}

int rowsA = InputData("Введите количество строк массива A ");
int columsA = InputData("Введдите количество столбцов массива A ");
int rowsB = InputData("Введите количество строк массива B ");
int columsB = InputData("Введдите количество столбцов массива B ");
int min = InputData("Введите минимальное значение элемента массива ");
int max = InputData("Введите максимальное значение элемента массива ");
if (IsValidSizeArray(rowsA, columsA) && IsValidSizeArray(rowsB, columsB))
{
    int[,] ArrayA = FillArray(rowsA, columsA, min, max);
    int[,] ArrayB = FillArray(rowsB, columsB, min ,max);
    PrintArray(ArrayA);
    Console.WriteLine();
    PrintArray(ArrayB);
    Console.WriteLine();
    if (IsValidMultliplicationArray(columsA, rowsB))
    {
        int[,] multiArray = MultiplicationArray(ArrayA, ArrayB);
        PrintArray(multiArray);
    }
}