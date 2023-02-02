Console.WriteLine("Please input your number, to see all the numbers between it and 1:");
string strUserInput = Console.ReadLine();
double UserInput = Convert.ToDouble(strUserInput);
double ogUserInput = UserInput;

if(ogUserInput == -1) Console.WriteLine("There are no even numbers between it and 1.");
else{
if(ogUserInput == 0) Console.WriteLine("There are no even numbers between it and 1.");
else{
if(ogUserInput == 1) Console.WriteLine("There are no even numbers between, because the number is 1.");
else
{
if(ogUserInput < -1)
{
while(UserInput < -1)
{UserInput = UserInput / 2;}

if(UserInput == -1) 
{UserInput = ogUserInput;}
else
{UserInput = ogUserInput + 1;}
}
else 
{UserInput = 2;}


Console.Write("These are all the even numbers between 1 and ");
Console.Write(ogUserInput);
Console.Write(": ");

Math.Round(UserInput);
Math.Round(ogUserInput);
double FinalUserInput = UserInput;
double FinalogUserInput = ogUserInput;
double count = UserInput;

if(UserInput > 0)
{
while(count < (FinalogUserInput+1))
{
FinalUserInput = count;
Console.Write(FinalUserInput);
Console.Write(", ");
count = count + 2;
}
}
else
{
while(count < 1)
{
FinalUserInput = count;
Console.Write(FinalUserInput);
Console.Write(", ");
count = count + 2;
}
}
}}}