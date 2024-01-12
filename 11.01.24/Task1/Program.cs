
//Задайте массив.
//Напишитепрограмму,котораяопределяет,присутствуетлизаданноечисловмассиве.Программадолжнавыдатьответ:Да/Нет.
//Примеры
//[1 3 4 19 3], 8 => Нет
//[-4 3 4 1], 3 => Да


int[] arr = new int[5] { 1, 3, 4, 19, 3 };
int[] arr2 = new int[] { -4, 3, 4, 1 };
//int [] arr3 = new int[5];
//int [] arr4 = {1,3,4,19,3};

bool existNum = false;
int num = 8;

for (int i = 0; i < arr.Length; ++i)
{
    if (arr[i] == num)
    {
        existNum = true;
        // Console.WriteLine("Да");
    }

}
//Console.WriteLine("Нет");     
if (existNum)
    Console.WriteLine("Ye");
else
    Console.WriteLine("No");

Console.WriteLine(existNum ? "Yep" : "Nop");