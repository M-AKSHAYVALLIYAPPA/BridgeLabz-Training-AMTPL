namespace EmployeeWageComputation
{
    public class UC1_CheckPresence
    {
        public void Run()
        {
            Console.WriteLine("--- Use Case 1: Check Presence ---");
            // Constants
            int IS_FULL_TIME = 1;
            Random random = new Random();

            // Computation
            int empCheck = random.Next(0, 2); 
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present"); 
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.WriteLine("----------------------------------\n");
        }
    }
}