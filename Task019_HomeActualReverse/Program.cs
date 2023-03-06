Console.WriteLine("Please input your 5-digit number.");
string strUserInput = Console.ReadLine()??string.Empty;
int UserInput = Convert.ToInt32(strUserInput);

if(UserInput >= 100000 || UserInput < 10000) Console.WriteLine("This is NOT a 5-digit number.");
else
{
    int idDigit01 = UserInput/10000;
    int idDigit02 = (UserInput/1000) - (idDigit01*10);
    int idDigit05 = UserInput%10;
    int idDigit04 = ((UserInput%100) - idDigit05)/10;

    if(idDigit01 == idDigit05 && idDigit02 == idDigit04) Console.WriteLine("The number IS a palidrome.");
    else
    {
        Console.WriteLine("The number IS NOT a palidrome.");
    }
}