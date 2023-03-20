int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int PowerFunction(int number_01, int number_02)
{
    if(number_02 == 0 || number_01 == 1) return 1;
    if(number_02 > 1) number_01 *= PowerFunction(number_01, number_02-1);
    return number_01;
}

int NumberA = ReadInt("Please input your initial number: ");
int NumberB = ReadInt("Please input the power you want to put the initial number in: ");
int PowerNumber = PowerFunction(NumberA,NumberB);
Console.WriteLine($"The number for {NumberA} in power of {NumberB} would be {PowerNumber}.");