int ReadInt(string message)
{
    Console.WriteLine(message);
    int n = Convert.ToInt32(Console.ReadLine());

    return n;
}
int AdvRecurNum(int n)
{
    if(n <= 0) return 0;
    if(n == 1) return 1;
    if(n > 1)
    {
    Console.Write($"{n}, ");
    AdvRecurNum(n-1);
    }
    return 1;
}

int inputNumber = ReadInt("Please input your number:");
Console.Write($"N = {inputNumber}: ");
Console.Write(AdvRecurNum(inputNumber));