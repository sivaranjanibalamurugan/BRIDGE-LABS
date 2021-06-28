using System;

namespace welcome
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO EMPLOYEE WAGES COMPUTATION PROGRAM");

            int empHours = 0;
            int empWages = 0;
            int totalWage = 0;

            Random random = new Random();
            for (int day = 1; day <= WORKING_DAYS; day++)
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
                totalWage += empWages;
            } 
            Console.WriteLine("Employee wage " + WORKING_DAYS + "day = "+ totalWage);
            Console.Read();
        }
    }
}
