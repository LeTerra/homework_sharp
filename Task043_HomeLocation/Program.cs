int[] IntArray(string message01, string message02)
{
    int[] array = new int[4];
    Console.WriteLine(message01);
    int number = Convert.ToInt32(Console.ReadLine());
    array[0] = number;
    for(int i = 1; i<array.Length; i++)
    {
        Console.WriteLine(message02);
        number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }
    return array;
}

(double, double) Intersection(int[] array)
{
    double c = array[0];
    double a = array[1];
    double d = array[2];
    double b = array[3];
    double x = (d - c)/(a - b);
    double y = (a*x)+c;

    return (x, y);
}

int[] IntersectionArray = IntArray("Please input the first coordinate: ", "Please input the next coordinate: ");
(double xCopy, double yCopy) = Intersection(IntersectionArray);
Console.WriteLine($"The point of intersection is such: x = {xCopy}, y = {yCopy}");