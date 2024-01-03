//Напишите программу, которая принимает на вход
//трёхзначное целое число и на выходе показывает сумму
//первой и последней цифры этого числа.
Console.WriteLine("enter a three-digit number:");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num < 99 || num > 999)
{   
        Console.WriteLine("value must have 3 digits");
        Console.WriteLine("enter a three-digit number:");
        num = Convert.ToInt32(Console.ReadLine());
}
if(num > 99 && num < 999)
{
    int firstNumSum = num / 100;
    int secontNumSum = num % 10;
    sum = firstNumSum + secontNumSum;
    Console.WriteLine($"sum first and last numbers={sum}");
}


    