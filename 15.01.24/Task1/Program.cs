//Задайте одномерный массив, заполненный случайными числами
//Определите количество простых чисел в этом массиве
//Примеры
//[1 34 193] => 2
//[4 341 9521 13] => 3


int size = 5;

int[] arr = GetArrayRndInt(size, max);
PrintArray(arr);

int CntPrimeNumbers = CountPrimeNumbers(arr);
Console.WriteLine($"=>{CntPrimeNumbers}");

int[] GetArrayRndInt(int size, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100);
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

int CountPrimeNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        //bool IsPrimeNumber = IsPrimeNumber(array[i]);
        if (IsPrimeNumber(array[i]))
                 ++count;
        
    }
            return count;
}

bool IsPrimeNumber(int num)
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}


