//Напишите программу, которая принимает
//на вход число и проверяет, кратно ли оно
//одновременно 7 и 23


Console.WriteLine("enter the number a = ");

int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    Console.Write("\r=>divide by 23 and 7");
}
else
{
    Console.Write("\r=>not devide by 23 and 7");
}