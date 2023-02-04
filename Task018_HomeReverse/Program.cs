Console.WriteLine("Please input the number of your coordinate plane:");
string strKeyNumber = Console.ReadLine();
int KeyNumber = Convert.ToInt32(strKeyNumber);

if(KeyNumber < 1 || KeyNumber > 4) Console.WriteLine("Such a plane does not exist.");
else
{
    if(KeyNumber == 1) Console.WriteLine("This plane includes numbers ranging from x > 0 and y > 0.");
    if(KeyNumber == 2) Console.WriteLine("This plane includes numbers ranging from x < 0 and y > 0.");
    if(KeyNumber == 3) Console.WriteLine("This plane includes numbers ranging from x < 0 and y < 0.");
    if(KeyNumber == 4) Console.WriteLine("This plane includes numbers ranging from x > 0 and y < 0.");
    else
    {
      Console.WriteLine("Such a plane does not exist.");  
    }
}