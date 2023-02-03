int RndIntgr = new Random().Next(10,99);
Console.WriteLine($"The chosen random number is {RndIntgr}.");

int RndIntgr01 = RndIntgr/10;
int RndIntgr02 = RndIntgr % 10;
Console.WriteLine($"Its' two digits are {RndIntgr01} and {RndIntgr02}.");

int max = RndIntgr01;
if(RndIntgr01 == RndIntgr02) Console.Write("Both integer values are equal to each other.");
else
{
if(RndIntgr02 > max) max = RndIntgr02;
Console.Write($"The biggest integer out of the two digits is {max}.");
}