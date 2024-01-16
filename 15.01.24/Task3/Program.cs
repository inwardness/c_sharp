
//Заполните массив на N (вводится с консоли, не более 8)
//случайных целых чисел от 0 до 9.
//Сформируйте целое число, которое будет состоять из цифр из
//массива. Старший разряд числа находится на 0-м индексе,
//младший – на последнем.
//Пример
//[1 3 2 4 2 3] => 132423
//[2 3 1] => 231


Console.WriteLine("Enter a array length");
int n = Convert.ToInt32(System.Console.ReadLine());
int[] array = GetArrayRndInt(n,10);
PrintArray(array);
CalcNumber(array);
int number = CalcNumber(array);
Console.WriteLine($" => {number}");
int[] GetArrayRndInt(int size, int max)
{
    int[] array = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10);
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

int CalcNumber(int[] array)
{
    int number = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        number = number*10 + array[i];
    }
    return number;
}

