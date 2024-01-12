//Задача с пятью гирями
//найти вес самой тяжёлой

Console.WriteLine("enter value first weight:");
int weigths1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter value second weight:");
int weigths2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter value third weight:");
int weigths3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter value fourth weight:");
int weigths4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter value fifth weight:");
int weigths5 = Convert.ToInt32(Console.ReadLine());

int max = weigths1;

if (weigths2 > max)
{
    max = weigths2;
}

if (weigths3 > max)
{
    max = weigths3;
}

if (weigths4 > max)
{
    max = weigths4;
}

if (weigths5 > max)
{
    max = weigths5;
}
Console.WriteLine($"max weight is:{max}");