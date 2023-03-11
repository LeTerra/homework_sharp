string FibArray(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[number];

    int exception = 0;
    string finalArray = string.Empty;

    if(array.Length == 0) exception = 1;
    if(array.Length == 1) 
    {
        exception = 2;
        array[0] = 0;
    }
    if(array.Length > 1) array[1] = 1;

    if(array.Length > 2)
    {
    for(int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    }

    if(exception == 0) finalArray = ($"These are the first {number} numbers of Fibonacchi sequence: {string.Join(", ", array)}");
    if(exception == 1) finalArray = ($"There are zero numbers.");
    if(exception == 2) finalArray = ($"The only number in the sequence is 0.");

    return finalArray;
}

string Fibonacchi = FibArray("Please input your number:");
Console.WriteLine(Fibonacchi);