(int, int) ReadInt(string message01, string message02)
{
    Console.WriteLine(message01);
    int Number01 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(message02);
    int Number02 = Convert.ToInt32(Console.ReadLine());

    return (Number01,Number02);
}

int[,] FormDArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = j+i;

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


(int a, int b) = ReadInt("Please input the number of rows: ", "Please input the number of columns: ");
Console.WriteLine();
int[,] FormulaeArray = FormDArray(a,b);
PrintMethod(FormulaeArray);