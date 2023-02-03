int RndInput = new Random().Next(100,999);
Console.WriteLine($"The selected number is {RndInput}.");

int defIntgr01 = (RndInput % 10);
int defIntgr03 = (RndInput / 100)*10;
int OutputIntgr = defIntgr01 + defIntgr03;

Console.WriteLine($"The output number is {OutputIntgr}.");
