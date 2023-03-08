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

int LocateMinMax (int[] array)
{
    int max = array[0];
    int min = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>=max) max = array[i];
        if(array[i]<=min) min = array[i];
    }
    int diff = max-min;
    return diff;
}

const int LENGTH = 5;
const int LEFT = 1;
const int RIGHT = 10;

int[] massive = GetRandomArray(LENGTH,LEFT,RIGHT); 
Console.WriteLine($"This is the original array: {string.Join(", ", massive)}.");
int Difference = LocateMinMax(massive);
Console.WriteLine($"The difference between the maximum and minimum values of the array is {Difference}.");