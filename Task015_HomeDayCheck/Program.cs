Console.WriteLine("Please write the number, so we could identify if it belongs to a weekday.");
string strUserInput = Console.ReadLine();
int UserInput = Convert.ToInt32(strUserInput);

if(UserInput < 1 || UserInput > 7)
{
    Console.WriteLine("There is no weekday asssigned to the inputted number.");
}
else
{
    if(UserInput == 6 || UserInput == 7)
    {Console.WriteLine("This number is assigned to a weekend.");}
    else{
        Console.WriteLine("This number is NOT assigned to a weekend.");
    }

}
