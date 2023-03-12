(int, int) ReadInt(string message01, string message02)
{
    Console.WriteLine(message01);
    int Number01 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(message02);
    int Number02 = Convert.ToInt32(Console.ReadLine());

    return (Number01,Number02);
}
int[,] RndDArray(int rows, int columns)
{
    Random rand = new Random();
    int[,] array = new int[rows,columns];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(0,10);
        }
    }
    return array;
}
void PrintMethod(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}, ");
        }
        Console.WriteLine();
    }
}

void Ascend(int[,] array)
{
    int temp01 = 0;
    int temp02 = 0;
    int tempMin = array[0,0];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < (array.GetLength(1))-1; j++)
        {
            temp01 = array[i,j];
            temp02 = array[i, j+1];
            if(temp01 > temp02) 
            {
                array[i,j+1] = temp01;
                array[i,j] = temp02;
                if(temp02<tempMin) 
                {
                    array[i,j] = tempMin;
                    array[i,0] = temp02;
                    tempMin = temp02;
                }
            }
        }
    }
    PrintMethod(array);
}

(int a, int b) = ReadInt("Please input the number of rows: ", "Please input the number of columns: ");
Console.WriteLine();

int[,] NewArray = RndDArray(a,b);
PrintMethod(NewArray);

Console.WriteLine();
Ascend(NewArray);