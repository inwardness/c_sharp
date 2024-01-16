//1. Задайте одномерный массиваб заполненный случайными числами.
//2. -Определите количество простых чисел в этом массиве
//примеры:
//[1 34 183] => 5;
// [4 341 9521 13] => 3
using System;
int size = 5;
int[] arr = GetArrayRndInt(size, 10000);
printArray(arr);


int[] GetArrayRndInt(int size,
                     int max)
{
    int[] array = new int[size];

    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
    array[i] = rnd.Next(max);
    }
    return array;
}

void printArray(int array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}
