using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class UC5_WagesForMonth
    {
        public void CalculateWagesForMonth()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int NUM_OF_WORKING_DAYS = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            Random random = new Random();

            for (int day = 1; day <= NUM_OF_WORKING_DAYS; day++)
            {
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Day {0}: Emp Hours = {1}, Wage = {2}", day, empHrs, empWage);
            }
            Console.WriteLine("Total Employee Wage for Month: " + totalEmpWage);
        }
    }
}
