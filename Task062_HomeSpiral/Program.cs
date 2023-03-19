(int, int) ReadInt(string message01, string message02)
{
    Console.WriteLine(message01);
    int Number01 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(message02);
    int Number02 = Convert.ToInt32(Console.ReadLine());

    return (Number01,Number02);
}
int[,] SpiralArray(int rows, int columns)
{
    int tempX = rows;
    int tempY = columns;
    int n = 0;
    int j = 0;

    int count = 1;
    int total = (rows+columns)-1;
    int[,] array = new int[rows,columns];
    if(total == 0) return array;
    
        while(j < tempY)
            {
                array[n, j] = count++;
                j++;
            }
        if(total == 1) return array;
        j--;
        n++;      
        while(n < tempX)
            {
                array[n, j] = count++;
                n++;
            }
        n--;
        if(total == 2) return array;
        if(total >= 2) {
        int times = 2;
        for(int i = 0; i < (total+1)/4; i++)
{
        j--;
        tempX--;
        while(j+1 > (columns - tempY))
            {
                array[n, j] = count++;
                j--;
            }
        times++;
        if(times == total) return array;
        n--;
        tempY--;
        j++;
        while(n+1 > (rows - tempX))
            {
                array[n, j] = count++;
                n--;
            }
        times++;
        if(times == total) return array;
        n++;
        j++;
        while(j < tempY)
            {
                array[n, j] = count++;
                j++;
            }
        if(times == total) return array;
        j--;
        n++;      
        while(n < tempX)
            {
                array[n, j] = count++;
                n++;
            }
        n--;
        if(times == total) return array;
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


(int a, int b) = ReadInt("Please input the number of rows for the array: ", "Please input the number of columns for the array: ");
Console.WriteLine();

int[,] NewArray01 = SpiralArray(a,b);
PrintMethod(NewArray01);