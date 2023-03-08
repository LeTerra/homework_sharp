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

int SumArray(int[] array)
{
int sum = 0;
   for(int i = 1; i < array.Length; i+=2)
   {
sum+=array[i];
   } 
   return sum;
}

const int LENGTH = 10;
const int LEFT = 0;
const int RIGHT = 150;

int[] massive = GetRandomArray(LENGTH,LEFT,RIGHT); 
Console.WriteLine($"This is the array: {string.Join(", ", massive)}.");
int GetSumOdd = SumArray(massive);
Console.WriteLine($"The total sum of all the odd elements of the array is {GetSumOdd}.");