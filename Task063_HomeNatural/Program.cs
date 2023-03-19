int ReadInt(string message)
{
    Console.WriteLine(message);
    int n = Convert.ToInt32(Console.ReadLine());

    return n;
}
double RecurNum(int n)
{
    if(n < 0) return -1;
    if(n == 1) return 1;
    Console.Write($"{RecurNum(n-1)}, ");
    return n;
}

int inputNumber = ReadInt("Please input your number:");
Console.Write($"N = {inputNumber}: ");
Console.Write(RecurNum(inputNumber));