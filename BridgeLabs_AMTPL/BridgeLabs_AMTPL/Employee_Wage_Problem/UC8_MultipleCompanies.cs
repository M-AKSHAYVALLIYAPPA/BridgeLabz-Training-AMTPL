using System;

namespace EmployeeWageComputation
{
    public class UC8_MultipleCompanies
    {
        // Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        // This method is parameterized
        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            // Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            // Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
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
                Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company: " + company + " is: " + totalEmpWage);
            return totalEmpWage;
        }

        public void Run()
        {
            Console.WriteLine("--- Use Case 8: Multiple Companies ---");
            // These were the calls in the Main method
            computeEmpWage("DMart", 20, 2, 10);
            computeEmpWage("Reliance", 10, 4, 20);
            Console.WriteLine("--------------------------------------\n");
        }
    }
}