using System;

namespace welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGES COMPUTATION PROGRAM");
            int employeepresent = 1;
            int empHours = 0;
            int empRatePerHour = 20;
            int empWages = 0;

            Random random = new Random();
            int empInput = random.Next(0, 2);
            if(empInput == employeepresent) 
            {
                Console.WriteLine("Employee is present");
                empHours = 8;
            }
            else 
            {
                Console.WriteLine("Employee is absent");
                empHours = 0;
            }
            empWages = empRatePerHour * empHours;
            Console.WriteLine("Employee wage per day = " +empWages);
            Console.Read();
        }
    }
}
