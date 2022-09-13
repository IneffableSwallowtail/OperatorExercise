// See https://aka.ms/new-console-template for more information
int a = 5;
int b = 7;
int sum = a + b;
Console.WriteLine($"{a} plus {b} equals {sum}");

a = 72;
b = 41;
int leftover = a - b;
Console.WriteLine($"\n{a} - {b} equals {leftover}");

a = 15;
b = 2;
int product = a * b;
Console.WriteLine($"\n{a} times {b} equals {product}");

a = 64;
b = 4;
int quotient = a / b;
int remainder = a % b;
Console.WriteLine($"\n{a}/{b} is {quotient} remainder {remainder}");
