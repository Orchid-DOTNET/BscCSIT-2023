

/*Assignment 4 (Simple Calculator using Interfaces and MultipleInheritance)
 
 * Assignment 5 (Exception Handling:DivideByZeroException) 
 
 * Used the calculator from assignment 4 and caught the DivideByZero Exception in the same calculator
*/
using multipleInheritance;
Calculator c = new Calculator();
var addition=c.add(5, 6);
var subtraction=c.sub(5, 5);
var multiply=c.mul(5, 6);
Console.WriteLine("Sum: {0}", addition);
Console.WriteLine("Sub: {0}", subtraction);
Console.WriteLine("Mul: {0}", multiply);

Calculator d = new Calculator();

d.div(15, 5);
d.div(15, 0);



