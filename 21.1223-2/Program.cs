//1. принимает на вход трёхзначное число
<<<<<<< HEAD
//2. удаляет вторую цифру этого числа
=======
//2. возводим второе число в степень числа третьего
>>>>>>> PC

Console.WriteLine("введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0) num*=-1;
if(num >= 100 && num <= 999)
{
    //int firstDigit = num / 100; //256/2
    int secondDigit = (num % 100)/10; //256=250+6
<<<<<<< HEAD
    int thirdDigit = num % 10;
    int result = 1;
    for(int i=0;i<=thirdDigit;++i)
    {
        result=result*thirdDigit;
=======
    Console.WriteLine(secondDigit);
    int thirdDigit = num % 10;
    Console.WriteLine(thirdDigit);
    int result = 1;
    for(int i=0;i<thirdDigit;++i)
    {
        result=result*secondDigit;
>>>>>>> PC
    }
    Console.WriteLine($"{num}=>{result}");
}