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
            employeeWage.addDetail("Reliance", 20, 25, 100);
            employeeWage.addDetail("Big-Bazaar", 50, 30, 150);
            employeeWage.ComputeWage();
            Console.Read();
        }
    }
}
    

