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

(int, string) FindEven(int[] array, string single, string multiple)
{
   int count = 0;
   string countMessage = multiple;
   for(int i = 0; i < array.Length; i++)
   {
    array[i] %= 2;
    if(array[i] == 0) count++;
   }
   if(count == 1) countMessage = single;
   return (count, countMessage);
}

const int LENGTH = 4;
const int LEFT = 100;
const int RIGHT = 999;

int[] massive = GetRandomArray(LENGTH,LEFT,RIGHT); 
Console.WriteLine($"This is the array: {string.Join(", ", massive)}.");
(int EvenCount, string EvenMessage) = FindEven(massive, "number", "numbers");
Console.WriteLine($"The array has {EvenCount} even {EvenMessage}.");