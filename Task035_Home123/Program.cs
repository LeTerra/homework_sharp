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

int ArrayRange(int[] array)
{
   int count = 0;
   for(int i = 0; i < array.Length; i++)
   {
    if(array[i] >= 10 && array[i] <= 99) count++;
   }
   return count;
}

const int LENGTH = 123;
const int LEFT = 0;
const int RIGHT = 150;

int[] massive = GetRandomArray(LENGTH,LEFT,RIGHT); 
Console.WriteLine($"This is the array: {string.Join(", ", massive)}.");
int CutCount = ArrayRange(massive);
if (CutCount == 1) 
{
    Console.WriteLine($"There is only {CutCount} number that lies in the range between 10 and 99 in this array.");
}
else
{
    Console.WriteLine($"There are {CutCount} numbers that lie in the range between 10 and 99 in this array.");
}