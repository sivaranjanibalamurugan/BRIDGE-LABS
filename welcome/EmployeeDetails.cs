using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welcome
{
    class EmployeeDetails
    {
        //global variables
        public string companyName;
        public int employeeRatePerHr;
        public int maxWorkingDays;
        public int maxWorkingHrs;
        private int totalWages;

        //Assign the values passed during object creation to current variables
        public EmployeeDetails(string companyName, int employeeRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            this.companyName = companyName;
            this.employeeRatePerHr = employeeRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }

        public void SetEmployeeWage(int wage)
        {
            this.totalWages = wage;
        }

        public string toString()
        {
            return "Total Employee wage for company \"" + this.companyName + "\" is :" + this.totalWages;
        }

    }
}

