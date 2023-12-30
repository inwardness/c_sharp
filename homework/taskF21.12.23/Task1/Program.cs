int firstNum = Console.ReadLine(Convert.ToInt32());
int secondNum = Console.ReadLine(Convert.ToInt32());

if( firstNum == secondNum * secondNum ) 
{
    Console.WriteLine($"a = {firstNum},b = {secondNum} => b is a quard a");
}
else
{
    Console.WriteLine($"a = {firstNum},b = {secondNum} => b is not a quard a");    
}