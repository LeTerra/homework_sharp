Console.WriteLine("Please input your three-digit number:");
string strUserInput = Console.ReadLine()??string.Empty;
int UserInput = Convert.ToInt32(strUserInput);

if(UserInput < 100)
{Console.WriteLine("This is NOT a three-digit number.");}
else{
if(UserInput >= 1000)
{Console.WriteLine("This is NOT a three-digit number.");}
else{

int defIntgr01 = UserInput % 1;
int defIntgr03 = (UserInput / 100)*100;
int defIntgr02 = (UserInput - (defIntgr01 + defIntgr03))/10;

Console.WriteLine($"The second digit is {defIntgr02}.");

}}
