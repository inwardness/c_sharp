//1. принимает на вход трёхзначное число
//2. возводим второе число в степень числа третьего

Console.WriteLine("введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0) num*=-1;
if(num >= 100 && num <= 999)
{
    //int firstDigit = num / 100; //256/2
    int secondDigit = (num % 100)/10; //256=250+6
    Console.WriteLine(secondDigit);
    int thirdDigit = num % 10;
    Console.WriteLine(thirdDigit);
    int result = 1;
    for(int i=0;i<thirdDigit;++i)
    {
        result=result*secondDigit;
    }
    Console.WriteLine($"{num}=>{result}");
}