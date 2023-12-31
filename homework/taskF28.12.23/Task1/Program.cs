
Console.WriteLine("Enter digit:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("divide by 23 and 7");
}
else
{
    Console.WriteLine("not devide by 23 and 7");
}