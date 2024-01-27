//Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить сколько среди букв гласных
//Пример
//"hello" => 2
//"world" => 1

int CountVowels(string str)
{
    int count = 0;
    str = str.ToLower();
    string Vowels = "eyuioa";

    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < Vowels.Length; j++)
        {
            if (str[i] == Vowels[j])
            {
                ++count;
            }
        }
    }

    return count;
}
Console.WriteLine("Enter a text string:\n");
string str = Console.ReadLine();
int count = CountVowels(str);

Console.WriteLine(count);
