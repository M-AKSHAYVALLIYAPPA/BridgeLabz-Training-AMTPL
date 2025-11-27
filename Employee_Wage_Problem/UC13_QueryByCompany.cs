using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class UC13_QueryByCompany
    {
        private Dictionary<string, int> companyWages = new Dictionary<string, int>();

        public void AddCompanyWage(string company, int totalWage)
        {
            companyWages[company] = totalWage;
        }

        public void DisplayCompanyWage(string company)
        {
            if (companyWages.ContainsKey(company))
                Console.WriteLine($"Total Wage for {company}: {companyWages[company]}");
            else
                Console.WriteLine($"Company {company} not found.");
        }
    }
}
