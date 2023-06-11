Console.Clear();
int xa=40, ya=10,
    xb=1, yb=40,
    xc=80, yc=40;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("*");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("*");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("*");
int x=xa, y=ya;
int Count=0;
while (Count < 10000)
{
    int n = new Random ().Next(0,3);
    if (n==0)
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
    }
    if (n==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
    if (n==2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("*");
    Count++;
}