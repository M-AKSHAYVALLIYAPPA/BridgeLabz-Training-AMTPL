namespace EmployeeWageComputation
{
    // This is the interface from page 37
    public interface IComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void computeEmpWage();
        int getTotalWage(string company);
    }
}