Console.WriteLine("Please input the week-day's number.");
string userInput = Console.ReadLine();

{
if (userInput == "1") userInput = "Monday";
if (userInput == "2") userInput = "Tuesday";
if (userInput == "3") userInput = "Wednesday";
if (userInput == "4") userInput = "Thursday";
if (userInput == "5") userInput = "Friday";
if (userInput == "6") userInput = "Saturday";
if (userInput == "7") userInput = "Sunday";
else
{
    Console.WriteLine("There is no day that would correspons to that number.");
}
Console.Write("Your weekday is ");
Console.Write(userInput);
}