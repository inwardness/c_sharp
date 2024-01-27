using System;
Console.WriteLine("Enter a massive:");
int[,] arr = new int[3, 4];
for (int i = 0; i < 3; ++i)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("mas[" + i + "," + j + "]: ");
        arr[i, j] = int.Parse(Console.Read());
    }
}

for (int i = 0; i < 3.; ++i)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(arr[i, j] + " ");
    }
}
