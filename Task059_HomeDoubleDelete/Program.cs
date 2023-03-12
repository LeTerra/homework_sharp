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

(int, int) MinPos(int[,] array)
{
    int tempMin = array[0,0];
    int tempRow = 0;
    int tempColumn = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < tempMin)
            {
                tempRow = i;
                tempColumn = j;
                tempMin = array[i, j];
            }
        }
    }
    return(tempRow, tempColumn);

}

void MinDel(int rowPos, int columnPos, int[,] array)
{
    int[,] outputArray = new int[(array.GetLength(0)-1),(array.GetLength(1)-1)];
    int rowOffset = 0;
    int columnOffset = 0;

    for(int i = 0; i < outputArray.GetLength(0); i++)
    {
        if(i == rowPos) rowOffset = 1;
        for(int j = 0; j < outputArray.GetLength(1); j++)
        {
          if(j == columnPos) columnOffset = 1;
          outputArray[i, j] = array[i+rowOffset, j+columnOffset]; 
        }
        columnOffset = 0;
    }
    Console.WriteLine("This is the final array, after the row and column on which the minimal value existed were removed: ");
    PrintMethod(outputArray);    
}

(int a, int b) = ReadInt("Please input the number of rows: ", "Please input the number of columns: ");
Console.WriteLine();

int[,] NewArray = RndDArray(a,b);
PrintMethod(NewArray);
Console.WriteLine();

(int rowPos, int columnPos) = MinPos(NewArray);
MinDel(rowPos, columnPos, NewArray);