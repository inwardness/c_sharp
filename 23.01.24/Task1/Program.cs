//Задайте массив символов  (тип char []). Создайте строку  из символов этого массива.
//Указание 
//Конструктор строки вида string ( char [] ) не использовать 
//['a','b','c','d'] => "abcd"

char[] ch  = {'a','b','c','d'};
string str = string.Empty;

for (int i = 0; i < ch.Length; i++)
{
    str += ch[i];
}

Console.WriteLine(str);