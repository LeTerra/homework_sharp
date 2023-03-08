int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumFunction(int number)
{
    int sum = 0;
    for(int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int InputNumber01 = ReadInt("Please input your number: ");
int FinalSum = SumFunction(InputNumber01);
Console.WriteLine($"The sum of numbers from 1 to {InputNumber01} is {FinalSum}.");