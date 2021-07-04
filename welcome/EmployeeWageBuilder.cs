using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcome
{
    class EmployeeWageBuilder
    { //adding constant global variable
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;

        //global variables
        string Company;
        int employeeRatePerHr;
        int maxWorkingDays;
        int maxWorkingHrs;
        private int totalWages;

        //Assign the values passed during object creation to current variables
        public EmployeeWageBuilder(string Company, int employeeRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            this.Company = Company;
            this.employeeRatePerHr = employeeRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void ComputeEmployeeWage()
        {
            //initialize local variable 
            int empHrs = 0;
            int empWages = 0;
            int monthlyWages = 0;
            int workingHr = 0;
            int day = 0;
            //Creating object or instance of Random class
            Random random = new Random();


            //Calculatin monthly Wages for 20days or for 100Hrs of work
            while (day <= this.maxWorkingDays && workingHr < this.maxWorkingHrs)
            {


                //Generating Random value by calling Next Method
                int empInput = random.Next(0, 3);

                //Checking employee status using switch case statement
                switch (empInput)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                //calculating Daily wages of Employee by Working Hours
                empWages = empHrs * employeeRatePerHr;
                monthlyWages = monthlyWages + empWages;
                workingHr += empHrs;

                if (empInput != 0)
                {
                    day++;
                }

            }
            totalWages = monthlyWages;
            //Console.WriteLine("Total working days :{0} \nTotal working hours:{1}", day, workingHr);
            Console.WriteLine("Total Employee wage for company \"{0}\" is :{1}\n\n", Company, monthlyWages);

        }

        public string toString()
        {
            return "Total Employee wage for company \"" + this.Company + "\" is :" + this.totalWages;
        }
    }
}
