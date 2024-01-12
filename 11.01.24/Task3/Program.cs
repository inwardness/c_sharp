int[] arr = new int[] { 1, 3, 2, 4, 2, 3};
int[] arr2 = new int[arr.Length/2];

for (int i = 0; i < arr.Length / 2; i++)
{
    arr2[i] = arr[i] * arr[arr.Length - i -1];
    Console.Write($"{arr2[i]} ");
}

