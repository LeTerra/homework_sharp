Console.WriteLine("Please input the first number.");
string StringUserNumA = Console.ReadLine();
int UserNumA = Convert.ToInt32(StringUserNumA);
Console.WriteLine("Please input the second number.");
string StringUserNumB = Console.ReadLine();
int UserNumB = Convert.ToInt32(StringUserNumB);

int result = UserNumA / UserNumB;

if(result == UserNumB) Console.WriteLine("The first number is the square of the second.");
else
{
    Console.WriteLine("The first number is NOT the square of the second.");
}