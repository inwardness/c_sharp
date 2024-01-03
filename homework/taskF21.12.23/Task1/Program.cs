//Напишите программу, которая на вход
//принимает два целых числа и проверяет,
//является ли первое число квадратом второго.
Console.WriteLine("checking whether the first number is the square of the second.\n ");
Console.WriteLine("enter first number:\n ");    
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter second number:\n ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if( firstNum == secondNum * secondNum ) 
{
    Console.WriteLine($"a = {firstNum},b = {secondNum} => a is a quard b");
}
else
{
    Console.WriteLine($"a = {firstNum},b = {secondNum} => b is not a quard a");    
}