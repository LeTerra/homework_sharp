int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Ackermann(int m, int n)
{
    int j = 0;
    if(m == 0) return n+1;
    if(m > 0 && n == 0) return j = Ackermann(m-1, 1);
    if(m > 0 && n > 0) j = Ackermann(m-1, Ackermann(m, n-1));

    return j;

}



int Number01 = ReadInt("Please input your first number: ");
int Number02 = ReadInt("Please input your second number: ");
int theAckermann = Ackermann(Number01,Number02);
Console.WriteLine($"This is the output of the Ackermann function, when given the numbers {Number01} and {Number02}: ");
Console.WriteLine(theAckermann);