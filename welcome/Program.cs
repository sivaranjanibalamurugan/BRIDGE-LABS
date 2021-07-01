using System;

namespace welcome
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;
        //UC7 Introducing class method 
         public static void ComputeWage()
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGES COMPUTATION PROGRAM");

            int empHours = 0;
            int empWages = 0;
            int totalWage = 0;
            int workingDays = 1;
            int workingHours = 0;

            Random random = new Random();
            while (workingDays<= MAX_WORKING_DAYS && workingHours<= MAX_WORKING_HRS)
            {
                int empInput = random.Next(0, 3);
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

                empWages = EMP_RATE_PER_HR * empHours;
                workingHours += empHours;
                totalWage += empWages;
                workingDays++;
            }
            Console.WriteLine("WorkingHrs =" + MAX_WORKING_HRS + "Working days=" + workingDays);
            Console.WriteLine("Employee wage for " + MAX_WORKING_DAYS + "days = "+ totalWage);

            
         }
        static void Main(string[] args)
        {
            ComputeWage();
            Console.Read();
        }
    }
}
