
//Задайте с строку,состоящую из слов,разделённых пробелами.
//Сформировать строку,в которой слова расположены в обратном порядке.
//В полученной строке слова должны быть так же разделены пробелами.
//"Hello my world"  => "world my Hello"
Console.WriteLine("Enter text:");
string str = Console.ReadLine();

ReverseWords(str);

static void ReverseWords(string str)
{
    string[] words = str.Split(' ');
    string resultStr = string.Empty;


    for (int i = words.Length - 1; i >= 0; i--)
    {
        if (i > 0)
        {
            resultStr += words[i] + " ";
        }
        else
        {
            resultStr += words[i];
        }
    }

    Console.WriteLine(resultStr);
}