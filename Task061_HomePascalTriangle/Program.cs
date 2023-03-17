int ReadInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int CountInt(int number)
{
    int count = 0;
    for(int i = number; i >= 1; i /= 10)
    {
        count++;
    }
    return count;
}

void PascalMethodAdv(int n)
{
    Console.Clear();

    int tempPos = 0;
    int tempCount = 0;

    int xa = 50, ya = 1;
    Console.SetCursorPosition(xa, ya);
    
    Console.WriteLine($"These are all the Pascal sequence rows up until {n}: ");
    int[] array = new int[1];
    array[0] = 1;
    int[] preArray = array;
    xa = 70; ya = 3;
    Console.SetCursorPosition(xa, ya);
    Console.Write($"{0} = {string.Join(" ", array)}");
    array = Array.Empty<int>();

    if(n>0)
{
    for(int i = 1; i <= n; i++)
    {
        Array.Resize<int>(ref array, i+1);
        array[0] = 1;
        array[i] = 1;
        if(n>1)
        {
        for(int j = 1; j < i; j++)
        {
            array[j] = (preArray[j-1] + preArray[j]);
        }
        
        tempPos = ((i+1)/2);
        tempCount = CountInt(array[tempPos]);
        xa-= tempCount;
        ya++;
        Console.SetCursorPosition(xa, ya);
        Console.Write($"{i} = {string.Join(" ", array)}");
        preArray = array;
        array = Array.Empty<int>();
        }
    }
}
}

int InputNumber = ReadInt("Please input your number: ");
PascalMethodAdv(InputNumber);