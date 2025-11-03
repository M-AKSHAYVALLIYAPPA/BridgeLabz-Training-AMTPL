using System; // Make sure this is at the top

namespace EmployeeWageComputation
{
    class Program12
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Use Case number to run (1-10) or '14' for the final solution.");
                Console.WriteLine("Press 'q' to quit.");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        new UC1_CheckPresence().Run();
                        break;
                    case "2":
                        new UC2_CalculateDailyWage().Run();
                        break;
                    case "3":
                        new UC3_AddPartTime().Run();
                        break;
                    case "4":
                        new UC4_UsingSwitchCase().Run();
                        break;
                    case "5":
                        new UC5_MonthlyWage().Run();
                        break;
                    case "6":
                        new UC6_WageWithCondition().Run();
                        break;
                    case "7":
                        new UC7_RefactorToMethod().Run();
                        break;
                    case "8":
                        new UC8_MultipleCompanies().Run();
                        break;
                    case "9":
                        Console.WriteLine("--- Use Case 9: Save Total Wage (Objects) ---");
                        // This logic was in the Main method on page 29
                        UC9_EmpWageBuilderObject dMart9 = new UC9_EmpWageBuilderObject("DMart", 20, 2, 10);
                        UC9_EmpWageBuilderObject reliance9 = new UC9_EmpWageBuilderObject("Reliance", 10, 4, 20);
                        dMart9.computeEmpWage();
                        Console.WriteLine(dMart9.ToString());
                        reliance9.computeEmpWage();
                        Console.WriteLine(reliance9.ToString());
                        Console.WriteLine("---------------------------------------------\n");
                        break;
                    case "10":
                        Console.WriteLine("--- Use Case 10: Manage Multiple (Arrays) ---");
                        // This logic was in the Main method on page 31
                        UC10_EmpWageBuilderArray empWageBuilder10 = new UC10_EmpWageBuilderArray();
                        empWageBuilder10.addCompanyEmpWage("DMart", 20, 2, 10);
                        empWageBuilder10.addCompanyEmpWage("Reliance", 10, 4, 20);
                        empWageBuilder10.computeEmpWage();
                        Console.WriteLine("-------------------------------------------\n");
                        break;
                    case "14": // UCs 11-14 are all part of this final solution
                        Console.WriteLine("--- Final Solution (UC 11-14) ---");
                        // This logic was in the Main method on page 37
                        EmpWageBuilder empWageBuilder = new EmpWageBuilder();
                        empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
                        empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
                        empWageBuilder.computeEmpWage();
                        Console.WriteLine("Total Wage for DMart company: " + empWageBuilder.getTotalWage("DMart"));
                        Console.WriteLine("---------------------------------\n");
                        break;
                    case "q":
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}