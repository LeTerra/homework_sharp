int ReadInt(string message)
{
    Console.WriteLine(message);
    int n = Convert.ToInt32(Console.ReadLine());

    return n;
}
int RecurNumSelect(int nMin, int nMax)
{
    if(nMin == nMax) return nMin;
    if(nMin < nMax)
    {
    Console.Write($"{nMin}, ");
    RecurNumSelect(nMin+1, nMax);
    }
    return nMax;
}

int inputMin = ReadInt("Please input the minimum number:");
int inputMax = ReadInt("Please input the maximum number:");
Console.Write($"The numbers between (and incl.) {inputMin} and {inputMax} are such: ");
Console.Write(RecurNumSelect(inputMin,inputMax));