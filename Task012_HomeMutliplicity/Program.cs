Console.WriteLine("Please input your first number:");
string strNumber01 = Console.ReadLine()??string.Empty;
double Number01 = Convert.ToDouble(strNumber01);
Console.WriteLine("Please input your second number:");
string strNumber02 = Console.ReadLine()??string.Empty;
double Number02 = Convert.ToDouble(strNumber02);

if(Number01 % Number02 == 0) Console.WriteLine("The first number IS the multiplication of the second number.");
else{
    Console.WriteLine("The first number IS NOT the multiplication of the second number.");
}