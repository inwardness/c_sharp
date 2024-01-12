int N = 10;
int[] arr = new int[N];
int i = 0;
while (i < arr.Length)
{
    arr[i] = i + 1;
    //Console.WriteLine(arr[i]); в столбец
    Console.Write(arr[i]); //в строку
    Console.Write(" ");
    i = i + 1;

}
