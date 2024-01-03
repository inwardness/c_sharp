//Напишите программу, которая принимает
//на вход целое число из отрезка [10, 99] и показывает
//наибольшую цифру числа
Console.WriteLine("Enter value from 10 to 99:");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10 || number > 99)
{
    Console.WriteLine("value must preset from 10 to 99");
    Console.WriteLine("Enter value from 10 to 99:");
    number = Convert.ToInt32(Console.ReadLine());
}

if (number > 10 || number < 99)
{
    int higherDigit = number / 10;
    int lowerDigit = number % 10;

    if (lowerDigit > higherDigit)
    {
        Console.WriteLine($"{lowerDigit} - higher value of number {number} ");
    }
    else
    {
        Console.WriteLine($"{higherDigit} - higher value of number {number} ");
    }
}