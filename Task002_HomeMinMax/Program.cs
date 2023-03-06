Console.WriteLine("Please input the first number.");
string StringUserNumA = Console.ReadLine()??string.Empty;
int UserNumA = Convert.ToInt32(StringUserNumA);
Console.WriteLine("Please input the second number.");
string StringUserNumB = Console.ReadLine()??string.Empty;
int UserNumB = Convert.ToInt32(StringUserNumB);
int max = 0;
int min = 0;

if(UserNumA == UserNumB) Console.WriteLine("The two numbers are equal to each other.");
else
{
if(UserNumA > UserNumB) 
{max = UserNumA; 
min = UserNumB;}
else
{
  {max = UserNumB; 
min = UserNumA;}  
}

{
    Console.Write("max = ");
    Console.Write(max);
    Console.Write("; ");
    Console.Write("min = ");
    Console.Write(min);
}}