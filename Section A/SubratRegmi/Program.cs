using Assignment2;
using Assignment1;
using Assignment3;
using Assignment4;
using Assignment5;
/*assignment 1
stringHandling sh = new stringHandling();
sh.stringPrint();*/
/*assignment 2
fileExercise fe = new fileExercise();
fe.LineCount();*/
/*assignment 3
EmployeeDetails emp = new EmployeeDetails();
emp.empDetails();*/
/*assignment4
Calculator c = new Calculator();
var addition = c.add(10, 2);
var subtract = c.sub(10, 2);
var divide = c.div(10, 2);
var multiply = c.mul(10, 2);
Console.WriteLine("Addition: {0}",addition);
Console.WriteLine("Subtraction: {0}", subtract);
Console.WriteLine("Division: {0}",divide);
Console.WriteLine("Multiplication: {0}", multiply);
*/
public class AssignmentsMain {
    public static void Main()
    {
        exceptionHandling eh = new exceptionHandling();
        int a,b;
        Console.WriteLine("Enter the value of a: ");
        a =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b: ");
        b = Convert.ToInt32(Console.ReadLine());
        eh.div(a, b);
    }
}
