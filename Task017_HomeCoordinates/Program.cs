Console.WriteLine("Please input your X coordinate:");
string strXCoordinate = Console.ReadLine();
int XCoordinate = Convert.ToInt32(strXCoordinate);
Console.WriteLine("Please input your Y coordinate:");
string strYCoordinate = Console.ReadLine();
int YCoordinate = Convert.ToInt32(strYCoordinate);

if(XCoordinate == 0 || YCoordinate == 0) Console.WriteLine("Since one of the coordinates is located at 0, it belongs to neither plane.");
else
{
    if(XCoordinate > 0 && YCoordinate > 0) Console.WriteLine("The coordinates inputted blong to the first plane.");
    if(XCoordinate < 0 && YCoordinate > 0) Console.WriteLine("The coordinates inputted blong to the second plane.");
    if(XCoordinate < 0 && YCoordinate < 0) Console.WriteLine("The coordinates inputted blong to the third plane.");
    if(XCoordinate > 0 && YCoordinate < 0) Console.WriteLine("The coordinates inputted blong to the fourth plane.");
}

