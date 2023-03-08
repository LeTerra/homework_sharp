   
int[] array = new int [8];
int i = 0;
Console.WriteLine("Please input the first number of the array: ");
int VarArray = Convert.ToInt32(Console.ReadLine());
array[i] = VarArray;
   
for(i = 1; i < array.Length; i++)
   {
    Console.WriteLine("Please input the next number of the array: ");
    VarArray = Convert.ToInt32(Console.ReadLine());
    array[i] = VarArray;
   }

Console.WriteLine(string.Join(", ", array));