Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите  второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
int remind = num1 % num2;
//if(num1||num2 < 0) num*=-1;
if(remind ==0 )

{
    
    Console.WriteLine($"{num1}=>кратно {num2}");
}
else
{
    Console.WriteLine($"{num1}=> не кратно {num2}, остаток {remind}");
}