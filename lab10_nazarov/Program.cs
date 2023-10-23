//средний 9
Console.WriteLine("|    x   |   y   |");
for(double x = 0; x<=3; x += 0.2)
{
    double y;
    if (x < 1) y = 1 + Math.Pow(x, 2);
    else if (x >= 0 && x <= 1.5) y = (Math.Pow(x, 2) - x);
    else y = 1 - Math.Sqrt(Math.Abs(Math.Cos(2 * x)));
    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
}