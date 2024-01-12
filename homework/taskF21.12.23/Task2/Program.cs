// Напишите программу, которая на вход принимает
//целое число N, а на выходе показывает все целые
//числа в промежутке от -N до N.
Console.WriteLine("Enter the number N =");
int N = Convert.ToInt32(Console.ReadLine());
int negN = -1 * N;
int i;
if (N > 0)
{
    for (i = negN; i <= N; ++i)
    {
        Console.Write($"{i} ");
    }
}
else
{
    for (i = N; i <= negN; ++i)
    {

        Console.Write($"{-1 * i} ");
    }
}
