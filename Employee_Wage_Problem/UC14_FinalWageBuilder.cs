using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class UC14_FinalWageBuilder : IComputeEmpWage
    {
        private List<UC9_SaveTotalWage> companyList = new List<UC9_SaveTotalWage>();
        private Dictionary<string, UC9_SaveTotalWage> companyToWageMap = new Dictionary<string, UC9_SaveTotalWage>();

        public void AddCompany(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            UC9_SaveTotalWage companyEmpWage = new UC9_SaveTotalWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyList.Add(companyEmpWage);
            companyToWageMap[company] = companyEmpWage;
        }

        public void ComputeWages()
        {
            foreach (var company in companyList)
            {
                company.ComputeEmpWage();
                Console.WriteLine(company.ToString());
            }
        }

        public int GetTotalWage(string company)
        {
            return companyToWageMap.ContainsKey(company) ? companyToWageMap[company].ToString().Length : 0;
        }
    }
}
