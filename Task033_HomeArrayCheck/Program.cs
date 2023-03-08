int[] GetRandomArray(int length, int leftRange, int rightRange)
{

int[] array = new int [length];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
   {
    array[i] = rand.Next(leftRange, rightRange + 1);
   }
   return array;
}

string ValidationArray(int[] array, string messageInput, string messageFalse, string messageTrue)
{
    string checkNumber = messageFalse;
    Console.WriteLine(messageInput);
    int userInput = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == userInput)
        {
            checkNumber = messageTrue;
            break;
        }
    }
    return checkNumber;
}

const int LENGTH = 5;
const int LEFT = -999;
const int RIGHT = 999;

int[] massive = GetRandomArray(LENGTH,LEFT,RIGHT); 
Console.WriteLine($"This is the array: {string.Join(", ", massive)}.");
string answer = ValidationArray(massive, "Please input your number: ", "There is no such number in the array.", "There is such a number in the array.");
Console.WriteLine(answer);