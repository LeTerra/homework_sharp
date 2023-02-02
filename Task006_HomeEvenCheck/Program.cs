Console.WriteLine("Please input your number:");
string strUserInput = Console.ReadLine();
double UserInput = Convert.ToDouble (strUserInput);
if(UserInput == 1) Console.WriteLine("The number is odd.");
else
{
while(UserInput > 1)
{
    UserInput = UserInput / 2;
}
if(UserInput == 1) 
{
    Console.WriteLine("The number is even.");
}
else
{
    Console.WriteLine("The number is odd.");
}
}