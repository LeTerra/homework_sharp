﻿(int, int) ReadInt(string message01, string message02)
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

void ChangeRTC(int[,] array)
{
    int temp = 0;
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            temp = array[j,i];
            newArray[i, j] = temp;
        }
    }
    PrintMethod(newArray);
}

(int a, int b) = ReadInt("Please input the number of rows: ", "Please input the number of columns: ");
Console.WriteLine();

int[,] NewArray = RndDArray(a,b);
PrintMethod(NewArray);

Console.WriteLine();
ChangeRTC(NewArray);