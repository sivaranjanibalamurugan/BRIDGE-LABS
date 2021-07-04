using System;

namespace welcome
{
    class Program
    {
        //class method to compute the employee wages

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            bool Continue = true;
            //creating object for each company
            EmployeeWageBuilder employeeWage = new EmployeeWageBuilder();

            while (Continue)
            {
                Console.WriteLine("Enter 1 to enter detail or 2 to display emp wage: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        GetDetail(employeeWage);
                        break;
                    case 2:
                        Console.WriteLine("enter company name to get total wage:");
                        string name = Console.ReadLine();
                        Console.WriteLine(employeeWage.GetEmployeeWage(name));
                        break;
                    default:
                        Continue = false;
                        break;
                }
            }
            Console.Read();
        }

        public static void GetDetail(EmployeeWageBuilder employee)
        {
            Console.WriteLine("Enter company name:");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter Rate per Hr:");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max working days:");
            int maxDays = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter max working hr:");
            int maxHr = Convert.ToInt32(Console.ReadLine());
            employee.addDetail(companyName, rate, maxDays, maxHr);
            employee.ComputeWage();
        }
    }
}
    

