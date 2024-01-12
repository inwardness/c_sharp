//На вход программе подаётся некоторое натуральное число N.
//Необходимо вывести на экран числа от 1 до этого введённого числа.
Console.WriteLine("Enter the number of limit cycle:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i<=num)
{
    Console.WriteLine(i );
    i = i + 1;
}
