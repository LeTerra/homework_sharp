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
int[] ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

const int LENGTH = 4;
const int LEFT = -9;
const int RIGHT = 9;

int[] massive = GetRandomArray(LENGTH,LEFT,RIGHT); 
Console.WriteLine($"This is the original array: {string.Join(", ", massive)}.");
int[] massiveReverse = ReverseArray(massive);
Console.WriteLine($"This is the reversed array: {string.Join(", ", massiveReverse)}.");
