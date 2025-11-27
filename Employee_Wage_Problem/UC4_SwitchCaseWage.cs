using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class UC4_SwitchCaseWage
    {
        public void CalculateWageUsingSwitch()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3); // 0, 1, 2

            switch (empCheck)
            {
                case 1:
                    empHrs = 4;
                    Console.WriteLine("Employee is Working Part-Time");
                    break;
                case 2:
                    empHrs = 8;
                    Console.WriteLine("Employee is Working Full-Time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage: " + empWage);
        }
    }
}
