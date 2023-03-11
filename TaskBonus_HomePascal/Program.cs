int ReadInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PascalMethod(int n)
{
    Console.WriteLine($"These are all the Pascal sequence rows up until {n}: ");
    int[] array = new int[1];
    array[0] = 1;
    int[] preArray = array;
    Console.WriteLine($"{0} = {string.Join(" ", array)}");
    array = Array.Empty<int>();

    if(n>0)
{
    for(int i = 1; i < n; i++)
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
        Console.WriteLine($"{i} = {string.Join(" ", array)}");
        preArray = array;
        array = Array.Empty<int>();
        }
    }
}
}

int InputNumber = ReadInt("Please input your number: ");
PascalMethod(InputNumber);