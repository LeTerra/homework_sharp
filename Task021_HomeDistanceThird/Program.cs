Console.WriteLine("Please input your first x-coordinate:");
string strX1 = Console.ReadLine();
Console.WriteLine("Please input your first y-coordinate:");
string strY1 = Console.ReadLine();
Console.WriteLine("Please input your third x-coordinate:");
string strZ1 = Console.ReadLine();

Console.WriteLine("Please input your second x-coordinate:");
string strX2 = Console.ReadLine();
Console.WriteLine("Please input your second y-coordinate:");
string strY2 = Console.ReadLine();
Console.WriteLine("Please input your third y-coordinate:");
string strZ2 = Console.ReadLine();

double intX1 = Convert.ToDouble(strX1);
double intY1 = Convert.ToDouble(strY1);
double intZ1 = Convert.ToDouble(strZ1);
double intX2 = Convert.ToDouble(strX2);
double intY2 = Convert.ToDouble(strY2);
double intZ2 = Convert.ToDouble(strZ2);

double result = Math.Sqrt(Math.Pow(intX1-intX2,2)+Math.Pow(intY1-intY2,2)+Math.Pow(intZ1-intZ2,2));
Console.WriteLine($"The total distance between two points is equal to {result:f2}.");