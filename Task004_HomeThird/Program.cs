Console.WriteLine("Please input your three-digit number:");
string strUserInput = Console.ReadLine()??string.Empty;
int UserInput = Convert.ToInt32(strUserInput);
if(UserInput < 100)
{
    Console.WriteLine("This is NOT a three-digit number.");
}
else{
if(UserInput >= 1000)
{
    Console.WriteLine("This is NOT a three-digit number.");
}
else{
int ogUserInput = UserInput;
UserInput = UserInput/10;
int InputTakeAway = ogUserInput - (UserInput*10);
Console.Write("The first digit of the given number is ");
Console.Write(InputTakeAway);
}
}