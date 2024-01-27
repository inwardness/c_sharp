//Задайте одномерный массив, заполненный случайными числами
//Определите количество простых чисел в этом массиве
//Примеры
//[1 34 193] => 2
//[4 341 9521 13] => 3


int size = 4;
int max = 999;
int[] arr = GetArrayRndInt(size, max);
PrintArray(arr);

int EvenNbrs = EvenNumbers(arr);
Console.WriteLine($"=>quantity of even numbers - {EvenNbrs}");

int[] GetArrayRndInt(int size, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(998);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}

int EvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        //bool IsPrimeNumber = IsPrimeNumber(array[i]);
        if ((array[i])%2 == 0)
                 ++count;
        
    }
            return count;
}


