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

(int, int) SumPositiveAndNegative(int[] array)
{
    int sumNegative = 0;
    int sumPositive = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) 
        {
            sumPositive += array[i];
    }
    else
    {
        sumNegative += array[i];
    }
    }
    return (sumPositive, sumNegative);
}

const int LENGTH = 12;
const int LEFT = -9;
const int RIGHT = 9;

int[] RndWorkingArray = GetRandomArray(LENGTH,LEFT,RIGHT); 
(int, int) arrayCalculation = SumPositiveAndNegative(RndWorkingArray);
Console.WriteLine(string.Join(", ", RndWorkingArray));
(int sumP, int sumN) = SumPositiveAndNegative(RndWorkingArray);
Console.WriteLine($"The sum of all the positive elements in the array is {sumP}; the negative elements sum up to {sumN}.");