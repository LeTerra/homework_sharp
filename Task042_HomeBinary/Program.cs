int ReadInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void BinaryNumber(int n)
{
    if(n <= 0) return;
    BinaryNumber(n / 2);
    Console.Write(n % 2);

}

int Number = ReadInt("Please input your number:");
BinaryNumber(Number);