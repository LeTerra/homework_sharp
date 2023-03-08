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

int[] GetMultiplicationArray(int[] array01)
{
    int exception = 1;
    int secondLength = (array01.Length/2)+1;
    if(array01.Length % 2 == 0) 
    {
        secondLength = array01.Length/2;
        exception = 0;
    }

    int[] array02 = new int[secondLength];

    int placeholderLength = array01.Length - 1;
    int digit = 0;
    for(int i = 0; i < secondLength; i++)
    {
    digit = array01[i]*array01[placeholderLength];
    array02[i] = digit;
    placeholderLength--;
    }
    if(exception == 1) array02[placeholderLength+1] = array01[placeholderLength+1];
    return array02;
}

const int LENGTH = 5;
const int LEFT = 0;
const int RIGHT = 10;

int[] massive = GetRandomArray(LENGTH,LEFT,RIGHT); 
Console.WriteLine($"This is the original array: {string.Join(", ", massive)}.");
int[] secondArray = GetMultiplicationArray(massive);
Console.WriteLine($"This is the new array, obtained through multiplying the paired digits of the previous one: {string.Join(", ", secondArray)}.");