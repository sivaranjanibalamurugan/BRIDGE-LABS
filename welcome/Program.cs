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
                EmployeeWageBuilder employeeWage = new EmployeeWageBuilder();
                employeeWage.addDetail("Zoho", 90, 10, 150);
                employeeWage.addDetail("flipkart", 75, 40, 300);
                employeeWage.ComputeWage();
                Console.Read();
            }
        
    }
}
    

