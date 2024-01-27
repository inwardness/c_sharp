//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
//[1 34 193] => [193 34 1]
//[4 341 9521 13] => [13 9521 341 4]


int size = 5;
int max = 999;
int[] arr = GetArrayRndInt(size, max);
PrintArray(arr);
ReverseArray(arr, size);


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
    Console.WriteLine("\n");
}

void ReverseArray(int[] array, int size)
{
    int convert1;
    for (int i = 0; i < (size / 2); i++)
    {
        convert1 = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = convert1;
        
    }
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
}




