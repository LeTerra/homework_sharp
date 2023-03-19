int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumFunction(int sum)
{

    if(sum == 0) return 0;
    else
    {
        sum = sum%10 + SumFunction(sum/10);
    }
    return sum;
    
}


int theNumber = ReadInt("Please input your number: ");
int theSum = SumFunction(theNumber);
Console.WriteLine($"The sum of all the digits in that number is {theSum}.");