

//Задайте массив из N случайных целых чисел (N вводится с клавиатуры)
//Найлите количество чисел,которые оканчиваются на 1 и на 7


int n = Convert.ToInt32(System.Console.ReadLine());
int[] array = GetArrayRndInt(n,100);
int count = FindNumber(array);
PrintArray(array);
Console.WriteLine($" => {count}");

int[] GetArrayRndInt(int size, int max)
{
    int[] array = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100);
    }

    return array;
}

int FindNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == 1 || array[i] % 7 == 0)
            ++count;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

}





