int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int PowerFunction(int number_01, int number_02)
{
    int initialNum = number_01;
    for(int i = 1; i < number_02; i++)
    {
        number_01 = initialNum*number_01;
    }
    return number_01;
}

int NumberA = ReadInt("Please input your first number: ");
int NumberB = ReadInt("Please input your second number: ");
int PowerNumber = PowerFunction(NumberA,NumberB);
Console.WriteLine($"The number for {NumberA} in power of {NumberB} would be {PowerNumber}.");