int InputData(string msg)
{
    Console.Write(msg);
    int data = int.Parse(Console.ReadLine());
    return data;
}

bool IsValid(int side)
{
    return (side > 0);
}

int[,] FillSnailArray(int side)
{
    int[,] snailArray = new int[side, side];
    int temp = 1;
    int x = 0;
    int y = 0;
    int w = 0;
    int m = side;
    for (int i = 0; i < m; i++)
    {
        //вправо
        for (int j = 0; j < m - w; j++)
        {
            snailArray[i, j + w] = temp;
            temp++;
            if (j + w == m - 1)
            {

                //вниз
                for (int k = w + 1; k < m; k++)
                {
                    snailArray[k, j + w] = temp;
                    temp++;
                    if (k == m - 1)
                    {

                        // влево
                        for (int l = m - (w + 2); l >= x; l--)
                        {
                            snailArray[k, l + w] = temp;
                            temp++;
                            if (l == 0)
                            {

                                // вверх
                                for (int n = m - 2; n > 0 + w; n--)
                                {
                                    snailArray[n, l + w] = temp;
                                    temp++;

                                }
                                
                                
                            }
                        }
                    }
                }
            }
        }
        m--;
        
        w++;

    }
    return snailArray;
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

int sideA = InputData("Введите сторону массива A ");
if (IsValid(sideA))
{
    int[,] snailArray = FillSnailArray(sideA);
    PrintArray(snailArray);
}