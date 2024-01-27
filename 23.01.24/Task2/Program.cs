// На основе символов строки (тип string) сформировать массив символов (тип char[]).
//Вывести массив на экран.
//указание.
//Метод строки ToCharArray() не использовать
// "Hello!"  => ['H','e','l','l','o','!']

string st = "Hello world!";

char[] result = StringToCharArray(st);
Console.Write($"\"{st}\"=>");
PrintCharArray(result);

char[] StringToCharArray(string st)
{
    char[] chars = new char[st.Length];

    for (int i = 0; i < st.Length; i++)
    {
        chars[i] = st[i];
    }

    return chars;
}

void PrintCharArray(char[] chars)
{
    Console.Write('[');
    for (int i = 0; i < chars.Length; i++)
    {
        if (i < chars.Length - 1)
        {
            Console.Write($"`{chars[i]}`,");
        }
        else
        {
            Console.Write($"'{chars[i]}'");
        }
    }
    Console.Write(']');
}
