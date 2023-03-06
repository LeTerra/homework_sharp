Console.WriteLine("Please input the first number.");
string StringUserNumA = Console.ReadLine()??string.Empty;
int UserNumA = Convert.ToInt32(StringUserNumA);
Console.WriteLine("Please input the second number.");
string StringUserNumB = Console.ReadLine()??string.Empty;
int UserNumB = Convert.ToInt32(StringUserNumB);
Console.WriteLine("Please input the third number.");
string StringUserNumC = Console.ReadLine()??string.Empty;
int UserNumC = Convert.ToInt32(StringUserNumC);
int max = UserNumA;

if(UserNumA > max) max = UserNumA;
if(UserNumB > max) max = UserNumB;
if(UserNumC > max) max = UserNumC;

Console.Write("The max number out of the three is ");
Console.Write(max);