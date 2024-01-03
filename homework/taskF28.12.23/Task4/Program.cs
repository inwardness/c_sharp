//Напишите программу, которая на вход
//принимает натуральное число N, а на выходе
//показывает его цифры через запятую
Console.WriteLine("Enter number:");
int valueInput = Convert.ToInt32(Console.ReadLine());
int i;
int rate = 1;
int counter = 0;
int valueCount = 0;
int reminder = 0;
//create the value of position power
counter = valueInput;
while (counter > 0)
{
    counter /= 10;
    valueCount = valueCount + 1;
}

for (i = 1; i < valueCount; ++i)
{
    rate *= 10;
}
//deviding input value by the position of numbers
if (valueCount == 1)
{
    Console.Write($"{valueInput}");
}
else
{
    while (valueInput > 0)
    {
        int quotient = valueInput / rate;
        int quotDigit = quotient;
        Console.Write($"{quotDigit},");
        reminder = valueInput % rate;
        valueInput = valueInput % rate;
        rate /= 10;
    }
}
