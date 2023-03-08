int arrayNegSum = 0;
int arrayPosSum = 0;
int newRngVal = 0;

int[] GetRandomArray(int length, int leftRange, int rightRange)
{

int[] array = new int [length];
for(int i = 0; i < array.Length; i++)
   {
    newRngVal = new Random().Next(leftRange, rightRange + 1);
    if(newRngVal >= 0) arrayPosSum += newRngVal;
    else
    {
        arrayNegSum += newRngVal;
    } 
    array[i] = newRngVal;
   }
   return array;
}

int[] RndWorkingArray = GetRandomArray(12,-9,9); 
Console.WriteLine(string.Join(", ", RndWorkingArray));
Console.WriteLine($"The sum of all the positive numbers in the array is {arrayPosSum}.");
Console.WriteLine($"The sum of all the negative numbers in the array is {arrayNegSum}.");