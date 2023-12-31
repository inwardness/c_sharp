Console.WriteLine("Enter two digits:");
Console.WriteLine("x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y:");
int y = Convert.ToInt32(Console.ReadLine());


while (x==0 || y==0)
{        
    Console.WriteLine("x and y doesn't can be equal 0");
    Console.WriteLine("Enter two digits:");
    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());
}

if(x > 0 && y > 0)
{
    Console.WriteLine("x and y in I - Coordinate Quarter");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("x and y in II - Coordinate Quarter");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("x and y in III - Coordinate Quarter");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("x and y in IV - Coordinate Quarter");
}
