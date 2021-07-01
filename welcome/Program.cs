using System;

namespace welcome
{
    class EmployeeWageBuilder
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        //instance variables creating separating for each object
        public string Company;
        public int empRatePerHr;
        public int maxWorkingDays;
        public int maxWorkingHrs;
       
        //UC7 Introducing class method 
         public static void ComputeWage(string company, int empRatePerHr,int maxWorkingDays, int maxWorkingHrs)
        {
            //Console.WriteLine("WELCOME TO EMPLOYEE WAGES COMPUTATION PROGRAM");

            int empHours = 0;
            int empWages = 0;
            int totalWage = 0;
            int workingDays = 1;
            int workingHours = 0;
            //creating object or instance of random class
            Random random = new Random();
            while (workingDays<= maxWorkingDays && workingHours<= maxWorkingHrs)
            {
                //calling Next() method for generating random values
               
                int empInput = random.Next(0, 3);
                //selection statement
                switch (empInput)
                {
                    case FULL_TIME:
                        empHours = 8;
                        break;
                    case PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                //applying formula for finding out employee salary
                empWages = empRatePerHr * empHours;
                workingHours += empHours;
                totalWage += empWages;//totalwages =totalWage+empWage;
                if ( empInput ! = 0)
                {
                    workingDays++;
                }
           
            }
            //Console.WriteLine("WorkingHrs = {0} Working days = {1}" , workingHours, workingDays);
            Console.WriteLine("Employee wage for {0} is {1}" ,company  ,totalWage);
         }
        static void Main(string[] args)
        {
            ComputeWage("Deloitee", 50,18,70);
            Console.Read();
        }
    }
}
