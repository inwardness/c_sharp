
using System.Globalization;

Console.WriteLine("введите трёхзначное число: ");
int numb = Convert.ToInt32(Console.ReadLine());
//if (numb < 0) { numb = numb * -1; }
if (numb < 0) { numb *= -1;}
if (numb >= 100 && numb <= 999)
{
    int digitH = numb / 100;
    int digitL = numb % 10;
    int number = digitH + digitL;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("число не трёхначное");
}
