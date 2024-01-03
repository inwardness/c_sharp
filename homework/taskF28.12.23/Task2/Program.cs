//Напишите программу, которая принимает
//на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
//0 и выдаёт номер координатной четверти плоскости,
//в которой находится эта точка.
Console.WriteLine("Enter x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y:");
int y = Convert.ToInt32(Console.ReadLine());


while (x == 0 || y == 0)
{
    Console.WriteLine("x or y doesn't can be equal 0");
    Console.WriteLine("Enter two digits:");
    x = Convert.ToInt32(Console.ReadLine());
    y = Convert.ToInt32(Console.ReadLine());
}

if (x > 0 && y > 0)
{
    Console.WriteLine("x and y in I - Coordinate Quarter");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("x and y in II - Coordinate Quarter");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("x and y in III - Coordinate Quarter");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("x and y in IV - Coordinate Quarter");
}
