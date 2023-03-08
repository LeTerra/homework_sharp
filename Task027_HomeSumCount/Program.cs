int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumFunction(int number)
{
    int sum = 0;
    for(int i = number; i > 1; i = i/10)
    {
        number = i % 10;
        sum += number;
    }
    return sum;
}


int theNumber = ReadInt("Please input your number: ");
int theSum = SumFunction(theNumber);
Console.WriteLine($"The sum of all the digits in that number is {theSum}.");