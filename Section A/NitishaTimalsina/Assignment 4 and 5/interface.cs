/*Assignment 4 (Simple Calculator using Interfaces and MultipleInheritance)
 
 * Assignment 5 (Exception Handling:DivideByZeroException) 
 
 * Used the calculator from assignment 4 and caught the DivideByZero Exception in the same calculator
*/


namespace multipleInheritance
{
    interface cal1
    {
        public int add(int x, int y);
    }
    interface cal2
    {
        public int sub(int x, int y);
    }
    interface cal3
    {
        public int mul(int x, int y);
    }
    interface cal4
    {
        public void div(int x, int y);
    }
}

