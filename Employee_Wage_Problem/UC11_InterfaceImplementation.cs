using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class UC12_SaveEachCompanyWage : IComputeEmpWage
    {
        private List<UC9_SaveTotalWage> companyList = new List<UC9_SaveTotalWage>();
        private Dictionary<string, int> companyToWage = new Dictionary<string, int>();

        public void AddCompany(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            UC9_SaveTotalWage companyEmpWage = new UC9_SaveTotalWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyList.Add(companyEmpWage);
        }

        public void ComputeWages()
        {
            foreach (var company in companyList)
            {
                company.ComputeEmpWage();
                string result = company.ToString();
                Console.WriteLine(result);
                string[] parts = result.Split(' ');
                int wage = int.Parse(parts.Last());
                companyToWage[parts[5]] = wage; // store by company name
            }
        }

        public int GetTotalWage(string company)
        {
            return companyToWage.ContainsKey(company) ? companyToWage[company] : 0;
        }
    }
}
