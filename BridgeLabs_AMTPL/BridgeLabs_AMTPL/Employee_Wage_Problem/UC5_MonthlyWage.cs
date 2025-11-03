namespace EmployeeWageComputation
{
    public class UC5_MonthlyWage
    {
        // Constants
        public const int IS_PART_TIME = 1; 
        public const int IS_FULL_TIME = 2; 
        public const int EMP_RATE_PER_HOUR = 20; 

        // Note: The UC title says 20 days [cite: 228][cite_start], but the code uses 2[cite: 235]. I'll use 20.
        public const int NUM_OF_WORKING_DAYS = 20;

        public void Run()
        {
            Console.WriteLine("--- Use Case 5: Calculate Monthly Wage ---");
            // Variables
            int empHrs = 0, empWage = 0, totalEmpWage = 0; 

            // Computation
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++) // [cite: 242]
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUR; 
                totalEmpWage += empWage; 
                Console.WriteLine("Emp Wage on Day " + (day + 1) + " : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage); 
            Console.WriteLine("----------------------------------------\n");
        }
    }
}