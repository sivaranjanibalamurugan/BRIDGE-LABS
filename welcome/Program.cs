using System;

namespace welcome
{
    class Program
    {
        //class method to compute the employee wages


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            //creating object for each company
            EmployeeWageBuilder zoho = new EmployeeWageBuilder("zoho", 20, 25, 100);
            EmployeeWageBuilder flipkart = new EmployeeWageBuilder("flipkart", 50, 30, 150);
            //computing employee wages for zoho company
            zoho.ComputeEmployeeWage();
            Console.WriteLine(zoho.toString());
            //computing employee wages for flipkart company
            flipkart.ComputeEmployeeWage();
            Console.WriteLine(flipkart.toString());
            Console.Read();
        }
    }
}
    

