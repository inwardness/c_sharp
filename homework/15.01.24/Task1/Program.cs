//Задача 1: Напишите программу, которая бесконечно
//запрашивает целые числа с консоли. Программа
//завершается при вводе символа ‘q’ или при вводе
//числа, сумма цифр которого четная.
Console.WriteLine("The program ends if the sum of the numbers of the entered value is even or when entering the letter  'q'");
Console.WriteLine("Enter number:");

string text;
char ch = 'c';
int number;
int summa = 0;
while (ch != 'q')
{
    summa = 0; number = 0; 
    text = Console.ReadLine();

    number = Convert.ToInt32(text);
    ch = Convert.ToChar(number);
    Console.WriteLine(ch);
    Console.WriteLine(number);
    if (ch != 'q')
    {
        summa = sum(number);
        if (summa % 2 != 0)
        {
            Console.WriteLine($"сумма чисел нечётная:\n{summa}");
        }
        else if (summa % 2 == 0)
        {
            Console.WriteLine($"сумма чисел чётная:\n{summa}");
            break;
        }

    }

    int sum(int number)
    {
        int sumi = 0;
        int value = number;
        int remain;
        int degree = 1;
        int firstNum = 0;
        while (number > 1)
        {
            remain = number % 10;
            sumi = sumi + remain;
            degree *= 10;
            number = number / 10;
            
        }
        firstNum = value / degree;
        sumi += firstNum;
        number = number / 1;
        
        return sumi;
    }
}
