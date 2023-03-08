int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int CountFunction(int number)
{
    int countInt = 0;
    if(number <= -1) number = number * -1;
    for(int i = number; i >= 1; i = i/10)
    {
        countInt++;
    }
    return countInt;
}

int NumberInput = ReadInt("Please input your number: ");
int Result = CountFunction(NumberInput);
Console.WriteLine($"Number {NumberInput} has {Result} digits.");