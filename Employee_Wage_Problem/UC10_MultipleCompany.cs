using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class UC10_MultipleCompany
    {
        private List<UC9_SaveTotalWage> companyList = new List<UC9_SaveTotalWage>();

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
                Console.WriteLine(company.ToString());
            }
        }
    }
}
