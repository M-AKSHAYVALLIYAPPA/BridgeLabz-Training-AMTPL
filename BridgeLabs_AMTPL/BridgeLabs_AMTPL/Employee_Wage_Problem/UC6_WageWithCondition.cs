using System;

namespace EmployeeWageComputation
{
    public class UC6_WageWithCondition
    {
        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;

        // Using the values from the UC title: 100 hours and 20 days
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public void Run()
        {
            Console.WriteLine("--- Use Case 6: Wage with Monthly Condition ---");
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            // Computation
            // The logic from the PDF is now correctly placed *inside* the loop.
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            Console.WriteLine("---------------------------------------------\n");
        }
    }
}