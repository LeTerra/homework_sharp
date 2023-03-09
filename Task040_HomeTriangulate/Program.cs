int[] ReadTriInt(string message01, string message02)
{
    int[] array = new int[3];

    Console.WriteLine(message01);
    array[0] = Convert.ToInt32(Console.ReadLine());
    for(int i = 1; i < array.Length; i++)
    {
    Console.WriteLine(message01);
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

string triangulateCheck(int[] array, string yes, string no)

{
    string Validation = no;
    if(array[0] <= array[1]+array[2] && array[1] <= array[0]+array[2] && array[2] <= array[1]+array[0]) Validation = yes;
    return Validation;
}

int[] TriangleInput = ReadTriInt("Please input the length of the first side of the triangle.", "Please input the length of the next side of the triangle.");
string ValidationCheck = triangulateCheck(TriangleInput, "Such triangle is possible.", "Such triangle is impossible.");
Console.WriteLine(ValidationCheck);