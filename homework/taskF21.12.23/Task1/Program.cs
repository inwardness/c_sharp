﻿
Console.WriteLine("enter first number:\n ");    
int firstNum = Console.ReadLine(Convert.ToInt32());

Console.WriteLine("enter second number:\n ")
int secondNum = Console.ReadLine(Convert.ToInt32());

if( firstNum == secondNum * secondNum ) 
{
    Console.WriteLine($"a = {firstNum},b = {secondNum} => b is a quard a");
}
else
{
    Console.WriteLine($"a = {firstNum},b = {secondNum} => b is not a quard a");    
}