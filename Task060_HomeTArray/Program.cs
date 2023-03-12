int ReadInt(string message)
{
    Console.WriteLine(message);
    int n = Convert.ToInt32(Console.ReadLine());

    return n;
}
int[,,] ArrayFill(int times, int rows, int columns)
{
    int tempVar = 10;
    int[,,] array = new int[times,rows,columns];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {   
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = tempVar++;
            }
        }
    }

    return array;
}
void PrintMethod3D (int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int a = ReadInt("Please input the number of rows for the three-dimensional array: ");
int b = ReadInt("Please input the number of rows for the two-dimensional array: ");
int c = ReadInt("Please input the number of columns for the two-dimensional array: ");

int[,,] NewArray3D = ArrayFill(a,b,c);
PrintMethod3D(NewArray3D);