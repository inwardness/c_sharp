using System;

public class Answer
{
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введит свое решение ниже
        
        if (firstNumber > secondNumber)
        {
            System.Console.WriteLine($"Первое число '{firstNumber}' больше вторго числа '{secondNumber}'");
        } 
                else if (firstNumber < secondNumber)
        {
            System.Console.Write($"Второе число'{secondNumber}' больше первого числа '{firstNumber}'");
        }

        else if (firstNumber == secondNumber)
        {
            System.Console.Write($"Первое число '{firstNumber}' равно второму '{secondNumber}'");
        }
    }
    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int firstNumber, secondNumber;

        if (args.Length >= 2)
        {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 8;
            secondNumber = 2;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}
