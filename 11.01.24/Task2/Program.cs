﻿//Задайте массив из 10 элементов,заполненный числами из промежутка[-10,10].
//Замените отрицательные элементы на положительные,а положительные на отрицательные.
//Пример
//[1 -5 6]
//=> [-1 5 -6]



int[] arr = new int[10] { 4, -5, 9, -6, 7, -5, -1, -10, 2, 7 };
Console.Write("=>[");
for (int i = 0; i < arr.Length; ++i)

{


    arr[i] = arr[i] * -1;

    Console.Write(arr[i] + " ");
}
Console.Write("]");