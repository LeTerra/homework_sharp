int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int MultiSumFunction(int number)
{
    int sum = 1;
    for(int i = 1; i <= number; i++)
    {
        sum = sum*i;
    }
    return sum;
}

int NumberInput = ReadInt("Please input your number: ");
int SumOutput = MultiSumFunction(NumberInput);
Console.WriteLine($"The sum of all the multiplications from 1 to {NumberInput} is {SumOutput}.");