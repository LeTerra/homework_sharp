Console.WriteLine("Please input your number:");
string strUserInput = Console.ReadLine()??string.Empty;
double UserInput = Convert.ToDouble(strUserInput);


if(UserInput<1) Console.WriteLine("There are no integer squares up until this number.");
else
{
Console.Write("Here is the list of all the squares up until (and incl.) the given number: ");
for(double i = 1; i < UserInput+1; i++)
{
    double iSquare = Math.Pow(i,2);
    Console.Write($"{iSquare} ");
}
}