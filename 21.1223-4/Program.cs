//Напишите программу, которая выводит третью слева цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int number = num;
if(num < 0) num*=-1;
if(num >= 100)
{
    while(num > 999)
    {
        num = num / 10;// num /=10;

    }
    int result = num % 10;
    Console.WriteLine($"{result}");
}
else
{
    Console.WriteLine($"{number} третьей цифры нет");
}