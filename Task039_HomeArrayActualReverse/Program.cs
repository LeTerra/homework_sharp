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

void Reverse(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
    int temp = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = temp;
    }
}

const int LENGTH = 5;
const int LEFT = 0;
const int RIGHT = 10;

int[] massive = GetRandomArray(LENGTH,LEFT,RIGHT); 
Console.WriteLine($"This is the original array: {string.Join(", ", massive)}.");
Reverse(massive);
Console.WriteLine($"This is the reversed array: {string.Join(", ", massive)}.");