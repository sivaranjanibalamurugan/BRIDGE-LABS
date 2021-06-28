using System;

namespace welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGES COMPUTATION PROGRAM");
            int employeepresent = 1;
            Random random = new Random();
            int empInput = random.Next(0, 2);
                if (empInput == employeepresent)
                    {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent"); 
            }
            Console.Read();
        }
    }
}
