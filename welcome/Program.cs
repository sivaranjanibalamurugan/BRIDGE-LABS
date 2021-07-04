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
            EmployeeWageBuilder EmployeeWage = new EmployeeWageBuilder();
            EmployeeWage.addDetail("Zoho", 40, 15, 250);
            EmployeeWage.addDetail("flipkart", 40, 25, 350);
            EmployeeWage.ComputeWage();
            Console.Read();
        }
    }
}
    

