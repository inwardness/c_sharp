//1. принимает на вход трёхзначное число
//2. удаляет вторую цифру этого числа

Console.WriteLine("введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0) num*=-1;
if(num >= 100 && num <= 999)
{
    int firstDigit = num / 100; //256/2
    int lastDigit = num % 10; //256=250+6
    int result = firstDigit * 10  + lastDigit;
    Console.WriteLine($"{num}=>{result}");
}

