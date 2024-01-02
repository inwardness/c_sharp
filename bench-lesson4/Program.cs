using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
      int i=1;
       Console.Write($"number = {number} -> ");
      for(i=1;i<=number;++i)
      {
        if(i%2==0)
        {
            Console.Write(i);
            Console.Write("\t");
        }
      }


    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 8;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}      