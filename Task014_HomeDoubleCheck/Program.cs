Console.WriteLine("Please input your number:");
string strNumber01 = Console.ReadLine()??string.Empty;
double Number01 = Convert.ToDouble(strNumber01);

if(Number01 % 23 == 0 && Number01 % 7 == 0)
{
Console.WriteLine($"The number is divisible by both 7 and 23.");
}
else
{
    Console.WriteLine($"The number is NOT divisible by both 7 and 23.");
}

