//Задача с двумя гирями
//найти гирю с большим весом

Console.WriteLine("enter value first weight:");
int weigths1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter value second weight:");
int weigths2 = Convert.ToInt32(Console.ReadLine());

if (weigths1 > weigths2)
{

    Console.WriteLine($"weigth {weigths1} > weigth {weigths2}");
}
else
{

    Console.WriteLine($"weigth {weigths2} > weigth {weigths1}");
    //Console.WriteLine(weigths2);
}