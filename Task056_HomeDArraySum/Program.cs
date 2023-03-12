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

void ArraySumComp(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    int tempSum = 0;
    int tempRow = 0;

    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
        {
            tempSum += array[i,j];
        }
        sumArray[i] = tempSum;
        tempSum = 0;
    }
    int tempMin = sumArray[0];
    int countEqual = 0;
    for(int k = 0; k<(sumArray.Length); k++)
    {
        if(sumArray[k] == tempMin)
        {
            countEqual++;
        }
        if(sumArray[k] < tempMin) 
        {
            tempMin = sumArray[k]; 
            tempRow = k;
        }
    }
    if(countEqual == sumArray.Length)
    {
        Console.WriteLine($"The sum of all the rows is equal to each other.");
    }
    else
    {
        Console.WriteLine($"The row with the lowest sum of numbers is row #{tempRow+1}.");
    }
}

(int a, int b) = ReadInt("Please input the number of rows: ", "Please input the number of columns: ");
Console.WriteLine();

int[,] NewArray = RndDArray(a,b);
PrintMethod(NewArray);

Console.WriteLine();
ArraySumComp(NewArray);