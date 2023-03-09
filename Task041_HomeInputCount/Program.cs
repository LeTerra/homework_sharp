int InputCycle(string initial, string next, string stop)
{
    string safeword = "stop";
    int count = 0;
    int intInput = 0;

    Console.WriteLine(initial);
    for(int input = 0; input != 1; input = 0)
    {
        string temp = Console.ReadLine()??string.Empty;
        if(temp == safeword) 
        {
            input = 1;
            break;
        }
        intInput = Convert.ToInt32(temp);
        if(intInput > 0) count++;
        Console.WriteLine(next);
    }
Console.WriteLine(stop);
return count;
}

int UserInput = InputCycle("Welcome! Please input your numbers, and I'll tell you, how many of them are bigger than zero. If you want to stop, write 'stop' into the console.", "Please write your next number or type in 'stop':", "Calculating...");
if(UserInput == 1) Console.WriteLine($"There was only one number that was bigger than zero.");
else
{
    Console.WriteLine($"There were a total of {UserInput} numbers bigger than zero.");
}