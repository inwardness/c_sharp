﻿using System.Data.SqlTypes;
using System.ComponentModel.DataAnnotations;
int i1 = 5;
int i2 = 6;
int sum = i1 + i2;
Console.WriteLine("int+int:");
Console.WriteLine(sum);
long l1 = 6;
long sum2 = i1 + l1;
double d1 = 5.5;
double sum3 = i1 + d1;
Console.WriteLine("int+long:");
Console.WriteLine(sum2);
Console.WriteLine("int+double:");
Console.WriteLine(sum3);
int product = i1 * i2;
double product2 = i1 * d1;
Console.WriteLine("production:int * int:");
Console.WriteLine(product);
Console.WriteLine("production:int * double");
Console.WriteLine(product2);
int quotient  = i1 / i2;
Console.WriteLine("quotient:int / int");
Console.WriteLine(quotient);
double quotient2 = i1 / d1;
Console.WriteLine("quotient:int / double");
Console.WriteLine(quotient2);
