
string str = "1sG,:0"
    foreach (char ch in str)
{
    Console.WriteLine(ch + " - " + char.getUnicodeCategory(ch));\

}