Console.WriteLine("Please input your number:");
string strUserInput = Console.ReadLine();
int UserInput = Convert.ToInt32(strUserInput);
int ogUserInput = UserInput;
int count = 0;

while(count < (ogUserInput * 2)+1)
{
Console.Write(-UserInput);
Console.Write(", ");
UserInput = UserInput - 1;
count = count + 1;
}

