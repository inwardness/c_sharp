//Вычислить значение формулы , где a,b,c,d – некоторые числа
//(𝑎×𝑏)/𝑐+𝑑
//целые числа. Результат вывести на экран

Console.WriteLine("Enter number - a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number - b:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number - c:");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number - d:");
double d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("E = ( A * B )  /  ( C + D )");

double e = (a * b) / (c + d);

Console.WriteLine(e);

