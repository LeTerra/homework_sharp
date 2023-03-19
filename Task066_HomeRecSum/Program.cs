int ReadInt(string message)
{
    Console.WriteLine(message);
    int n = Convert.ToInt32(Console.ReadLine());

    return n;
}
int RecurNumSum(int nMin, int nMax)
{
    if(nMin == nMax) return nMin;
    if(nMin < nMax)
    {
    return nMin + RecurNumSum(nMin+1, nMax);
    }
    return nMin;
}

int inputMin = ReadInt("Please input the minimum number:");
int inputMax = ReadInt("Please input the maximum number:");
Console.Write($"The sum of numbers between (and incl.) {inputMin} and {inputMax} is such: ");
Console.Write(RecurNumSum(inputMin,inputMax));