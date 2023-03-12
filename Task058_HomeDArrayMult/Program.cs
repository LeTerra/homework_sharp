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
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void DArrayMult(int[,] array01, int[,] array02)
{
    int[,] arrayMult = new int[array01.GetLength(0), array01.GetLength(1)];

    for(int i = 0; i < array01.GetLength(0); i++)
        {
        for(int j = 0; j < array01.GetLength(1); j++)
        {
            arrayMult[i,j] = array01[i,j]*array02[i,j];
        }
        }
    Console.WriteLine($"This is the array produced as a result of multiplicating the elements of the two previous arrays: ");
    PrintMethod(arrayMult);
}


(int a, int b) = ReadInt("Please input the number of rows for the both arrays: ", "Please input the number of columns for the both arrays: ");
Console.WriteLine();

int[,] NewArray01 = RndDArray(a,b);
PrintMethod(NewArray01);
Console.WriteLine();
int[,] NewArray02 = RndDArray(a,b);
PrintMethod(NewArray02);
Console.WriteLine();

Console.WriteLine();
DArrayMult(NewArray01, NewArray02);