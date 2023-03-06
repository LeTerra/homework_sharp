Console.WriteLine("Please input your number, so we may display its' third digit:");
string strUserInput = Console.ReadLine()??string.Empty;
int UserInput = Convert.ToInt32(strUserInput);

if(UserInput/100 < 1) 
{Console.WriteLine("The selected number doesn't have a third digit.");}

else
{
    while(UserInput >= 1000)
    {
        UserInput = UserInput/10;
    }
    int defIntgr01 = (UserInput/100)*100;
    int defIntgr02 = UserInput-defIntgr01; 
    defIntgr02 = (defIntgr02/10)*10;
    int defIntgrComb = defIntgr01 + defIntgr02;

    UserInput = UserInput - defIntgrComb;
    Console.WriteLine($"The third digit of the given number is {UserInput}.");
}