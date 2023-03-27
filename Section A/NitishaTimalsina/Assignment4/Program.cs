// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using multipleInheritance;
Calculator c=new Calculator();
var addition=c.add(5, 6);
var subtraction=c.sub(5, 5);
var multiply=c.mul(5, 6);
var divide=c.div(25, 5);
Console.WriteLine("Sum: {0}", addition);
Console.WriteLine("Sub: {0}", subtraction);
Console.WriteLine("Mul: {0}", multiply);
Console.WriteLine("Div: {0}", divide);
