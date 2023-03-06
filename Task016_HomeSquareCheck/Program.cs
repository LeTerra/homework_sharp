Console.WriteLine("Please input your first number:");
string strNumber01 = Console.ReadLine()??string.Empty;
double Number01 = Convert.ToDouble(strNumber01);
Console.WriteLine("Please input your second number:");
string strNumber02 = Console.ReadLine()??string.Empty;
double Number02 = Convert.ToDouble(strNumber02);

if(Number01*Number01 == Number02 || Number02*Number02 == Number01)
{
    Console.WriteLine("One of the numbers IS the square of the other.");
}
else
{
Console.WriteLine("None of the numbers are the square of the other.");
}